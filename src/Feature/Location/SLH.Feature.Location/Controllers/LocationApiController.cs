using System;
using System.Globalization;
using System.Web.Http;
using Sitecore.Configuration;
using Sitecore.Data;
using Sitecore.Data.Items;
using System.Web.Mvc;
using System.Web.Routing;

namespace SLH.Feature.Location.Controllers
{
    public class LocationApiController : Controller
    {
        [System.Web.Mvc.HttpPost]
        public ActionResult UpdatePoi(string id, string top, string left)
        {
            Database database = Factory.GetDatabase("master");

            using (new Sitecore.SecurityModel.SecurityDisabler())
            {
                using (new DatabaseSwitcher(database))
                {
                    Item item = database.GetItem(id);
                    if (item == null) return Json(false);

                    try
                    {
                        item.Editing.BeginEdit();
                        using (new EditContext(item))
                        {
                            item.Fields[Constants.FieldId.PoiTop].Value = Math.Round(Convert.ToDecimal(top), 2).ToString(CultureInfo.InvariantCulture);
                            item.Fields[Constants.FieldId.PoiLeft].Value = Math.Round(Convert.ToDecimal(left), 2).ToString(CultureInfo.InvariantCulture);
                        }
                        item.Editing.EndEdit(false, true);
                        item.Editing.AcceptChanges();
                    }
                    catch (Exception e)
                    {
                        item.Editing.CancelEdit();
                        Sitecore.Diagnostics.Log.Error(e.Message, e, this);
                        return Json("Error: " + e.Message);
                    }
                }
            }

            return Json(true);
        }
    }
}