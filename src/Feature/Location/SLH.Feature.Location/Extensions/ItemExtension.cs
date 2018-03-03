using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data.Items;
using Sitecore.Resources.Media;

namespace SLH.Feature.Location.Extensions
{
    public static class ItemExtension
    {
        public static string GetMediaUrl(this Sitecore.Mvc.Helpers.SitecoreHelper sitecoreHelper, string fieldName)
        {
            return GetMediaUrl(sitecoreHelper, fieldName, sitecoreHelper.CurrentItem);
        }

        public static string GetMediaUrl(this Sitecore.Mvc.Helpers.SitecoreHelper sitecoreHelper, string fieldName, Item item)
        {
            MediaItem mediaItem = item.Fields[fieldName].Item;
            var url = Sitecore.Resources.Media.MediaManager.GetMediaUrl(mediaItem);
            return HashingUtils.ProtectAssetUrl(url);
        }
    }
}