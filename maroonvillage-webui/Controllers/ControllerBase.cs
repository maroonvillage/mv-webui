using maroonvillage.webui.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace maroonvillage.webui.Controllers
{
    public class ControllerBase : Controller
    {

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
        /// <summary>
        /// Creates the model and loads the default model data
        /// </summary>
        /// <typeparam name="T">The type of model to create.</typeparam>
        /// <param name="action">Optionally modify the returned model object.</param>
        /// <returns></returns>
        protected T CreateModel<T>(Action<T> action = null)
            where T : DefaultModel, new()
        {
            return LoadModelData(new T(), action);
        }
        /// <summary>
        /// Loads the default data into the given model
        /// </summary>
        /// <typeparam name="T">The type of model to create.</typeparam>
        /// <param name="model">The model to load the data into.</param>
        /// <param name="action">Optionally modify the returned model object.</param>
        /// <returns></returns>
        protected virtual T LoadModelData<T>(T model, Action<T> action = null)
            where T : DefaultModel
        {
            if (HttpContext.User != null && HttpContext.User.Identity.IsAuthenticated)
            {
                model.User = HttpContext.User;
            }

            action?.Invoke(model);

            return model;
        }

    }
}
