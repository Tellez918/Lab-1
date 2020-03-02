using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;
using MVCPlantilla.Utilerias;

namespace MvcPlantilla.Controllers
{
    public class VideosController : Controller
    {
        //
        // GET: /Videos/

        public ActionResult Index()
        {
            //Consultar datos en la DB
            ViewData["video"] = BaseHelper.ejecutarConsulta(
                "SELECT * FROM Video",
                CommandType.Text);
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        //POST Procesa los datos ingresados al formulario
        [HttpPost]
        public ActionResult Create(int idVideo,
                                     string titulo,
                                     int numReprod,
                                     string urlVideo)
        {
            //Guardar en SQL

            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idVideo", idVideo));
            parametros.Add(new SqlParameter("@titulo", titulo));
            parametros.Add(new SqlParameter("@numReprod", numReprod));
            parametros.Add(new SqlParameter("@urlVideo", urlVideo));

            BaseHelper.ejecutarSentencia("INSERT INTO Video" +
                                         "VALUES(@idVideo, @titulo," +
                                         "@numReprod, @urlVideo)", CommandType.Text, parametros);
            return View("Mensaje");

        }

    }
}
