using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Sitecore.Data.Fields;
using Sitecore.Mvc.Controllers;
using Sitecore.Mvc.Presentation;
using Sitecore.Resources.Media;
using SLH.Feature.Location.Models;

namespace SLH.Feature.Location.Controllers
{
    public class LocationController : SitecoreController
    {
        public ActionResult LocationMap()
        {
            var model = RenderingContext.Current.Rendering.Item;

            if (model == null)
            {
                return new EmptyResult();
            }

            var locationMapModel = new LocationMapViewModel();

            ImageField image = model.Fields[Constants.FieldId.LocationMapImage];
            if (image?.MediaItem != null)
            {
                locationMapModel.ImageUrl = MediaManager.GetMediaUrl(image.MediaItem);
                locationMapModel.ImageHeight = Convert.ToInt32(image.Height);
                locationMapModel.ImageWidth = Convert.ToInt32(image.Width);
            }

            var poiItemsList = new List<PoiItem>();
            MultilistField poiItems = model.Fields[Constants.FieldId.LocationMapPois];
            if (poiItems?.TargetIDs != null)
            {
                foreach (var poi in poiItems.GetItems())
                {
                    var title = poi.Fields[Constants.FieldId.PoiTitle].Value;

                    var poiItem = new PoiItem
                    {
                        Title = title,
                        Top = Convert.ToDecimal(poi.Fields[Constants.FieldId.PoiTop].Value),
                        Left = Convert.ToDecimal(poi.Fields[Constants.FieldId.PoiLeft].Value),
                        Id = poi.ID.Guid
                    };

                    ReferenceField iconField = poi.Fields[Constants.FieldId.PoiType];
                    var icon = Constants.FieldValue.PoiTypeIconClass;
                    if (iconField?.TargetItem != null)
                    {
                        icon = iconField.TargetItem.Fields[Constants.FieldId.PoiTypeIconClass].Value;
                    }
                    poiItem.IconClass = icon;

                    poiItemsList.Add(poiItem);
                }
            }

            locationMapModel.PoiItems = poiItemsList;

            return View(locationMapModel);
        }
    }
}