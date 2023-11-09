using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SabaLab_List.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppContext.ContextModel _context;

        public ContactController(AppContext.ContextModel context)
        {
            _context = context;
        }



        public async Task<IActionResult> Index()
        {
            return View(await _context.models.ToListAsync());
        }



        [HttpGet]
        public async Task<IActionResult> Index (string search, string orderby)
        {
            
            ViewData["GetContact"] = search;
            var query = from x in _context.models select x;

            switch (orderby)
            {
                case "EndOfSupport":

                    query = query.OrderByDescending(x => x.EndOfSupport);
                    break;

                default :

                    query = query.OrderBy(x => x.EndOfSupport);
                    break;
            }

            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(x => x.fullName.Contains(search) || x.DrName.Contains(search));
            }

            return View(await query.AsNoTracking().ToListAsync());
        }


        //public async Task<IActionResult> GetModule(int id)
        //{
        //    var query=_context.models.Where(x=> x.)

        //}




        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IsActive,fullName, DrName,DrMobile,MasoolAz,MasoolTel,Address,Phone,Description,EndOfSupport,LastMoney,ResponseOnline,LabManagerOnline,Media,MediaQR,Sms,Qc,Storage,BackupSync")] ModelLibrary.DataModels models)
        {
            if (ModelState.IsValid)
            {
                _context.Add(models);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(models);
        }

        //[HttpGet]
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var result = await _context.models.FirstOrDefaultAsync(m => m.Id == id);
        //    if (result == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(result);
        //}

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                // Retrieve the item from the database
                var item = _context.models.FirstOrDefault(i => i.Id == id);

                if (item == null)
                {
                    return NotFound(); // Item not found, return HTTP 404 Not Found
                }

                // Perform the deletion logic
                _context.models.Remove(item);
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                // Handle any exception that occurred during deletion
                return StatusCode(500, new { message = "An error occurred while deleting the item" });
            }
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            var result = await _context.models.FindAsync(id);
            _context.models.Remove(result);
            await _context.SaveChangesAsync();
            //var result1 = new { success = true, message = "Item deleted successfully" };
            //return Json(result1);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            var result = await _context.models.FindAsync(id);
            if (result==null)
            {
                return NotFound();
            }
            return View(result);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,[Bind("Id,IsActive,fullName, DrName,DrMobile,MasoolAz,MasoolTel,Address,Phone,Description,EndOfSupport,LastMoney,ResponseOnline,LabManagerOnline,Media,MediaQR,Sms,Qc,Storage,BackupSync")] DataModels dataModels)
        {
            if (id != dataModels.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.models.Update(dataModels);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DataModelsExists(dataModels.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                
            }
            return View(dataModels);
        }

    





        private bool DataModelsExists(int id)
        {
            return _context.models.Any(m => m.Id == id);
        }



    }
}
