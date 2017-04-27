using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Laboratorio4.Models
{    
    public class AnimalController : Controller
    {
        public static Dictionary<int, AnimalModel> Diccionario = new Dictionary<int, AnimalModel>();
        public static List<AnimalModel> Animales = new List<AnimalModel>();

        //
        // GET: /Animal/
        public ActionResult Index()
        {
            return View();
        }


        //
        // GET: /Animal/List
        public ActionResult List()
        {
            return View(Animales);
        }

        //
        // GET: /Animal/Details/5
        public ActionResult Details(int id)
        {
            return View(Diccionario[id]);
        }

        //
        // GET: /Animal/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Animal/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {

            try
            {
                // TODO: Add insert logic here
                int Id = int.Parse(collection["Id"].ToString());
                string Nombre = collection["Nombre"].ToString();
                int Ojos = int.Parse(collection["Ojos"].ToString());
                int Patas = int.Parse(collection["Patas"].ToString());
                string Apodo = collection["Apodo"].ToString();
                string Cubierta = collection["Cubierta"].ToString();
                AnimalModel animal = new AnimalModel(Id, Nombre, Ojos, Patas, Apodo, Cubierta);
                Diccionario.Add(animal.Id, animal);
                Animales.Add(animal);
                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Animal/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Animal/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Animal/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Diccionario[id]);
        }

        //
        // POST: /Animal/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
