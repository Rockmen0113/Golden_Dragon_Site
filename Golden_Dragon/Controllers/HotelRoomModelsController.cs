using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Golden_Dragon.Models;

namespace Golden_Dragon.Controllers
{
    public class HotelRoomModelsController : Controller
    {
        private ApplicationContext db = new ApplicationContext();

        // GET: HotelRoomModels
        public async Task<ActionResult> Index()
        {
            return View(await db.Hotel_Room.ToListAsync());
        }

        // GET: HotelRoomModels/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HotelRoomModel hotelRoomModel = await db.Hotel_Room.FindAsync(id);
            if (hotelRoomModel == null)
            {
                return HttpNotFound();
            }
            return View(hotelRoomModel);
        }

        // GET: HotelRoomModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HotelRoomModels/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID,Name,Description")] HotelRoomModel hotelRoomModel)
        {
            if (ModelState.IsValid)
            {
                db.Hotel_Room.Add(hotelRoomModel);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(hotelRoomModel);
        }

        // GET: HotelRoomModels/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HotelRoomModel hotelRoomModel = await db.Hotel_Room.FindAsync(id);
            if (hotelRoomModel == null)
            {
                return HttpNotFound();
            }
            return View(hotelRoomModel);
        }

        // POST: HotelRoomModels/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID,Name,Description")] HotelRoomModel hotelRoomModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hotelRoomModel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(hotelRoomModel);
        }

        // GET: HotelRoomModels/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HotelRoomModel hotelRoomModel = await db.Hotel_Room.FindAsync(id);
            if (hotelRoomModel == null)
            {
                return HttpNotFound();
            }
            return View(hotelRoomModel);
        }

        // POST: HotelRoomModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            HotelRoomModel hotelRoomModel = await db.Hotel_Room.FindAsync(id);
            db.Hotel_Room.Remove(hotelRoomModel);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
