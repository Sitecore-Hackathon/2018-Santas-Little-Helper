
# Location Map - Point of Interest Documentation

![Location POI](images/LocationPOI.png?raw=true "Location POI")

## Summary

**Category:** Sitecore Experience Accelerator SxA module

This module allows editors to easily add the common "**Point of Interest (POI)**" functionality to any page. The module displays a background image with some "pinpoints" defined in Sitecore, but dynamically using Sitecore Experience Accelerator (SxA) in order to allow the editor to preview the results in real time.

## Pre-requisites

Please make sure you have the following requirements installed:

- Sitecore 9.0 rev. 171219 (Update-1)
- Sitecore Experience Accelerator Module 1.6, which requires:
	- Sitecore PowerShell Extensions 4.7.2 for Sitecore 8/9

## Installation

Please follow this instructions to install this module:

1. Use the Sitecore Installation wizard to install the [package](#link-to-package)
2. Publish site

For more details, read our [Installation Guide](Installation_Guide.md)

### Enable the Feature on your existing site

1. Open Sitecore Content Editor

2. Select your site:

![SelectSite](images/SelectSite.PNG?raw=true "SelectSite")

3. Right click on your site, select **Scripts**, then **Add Site Feature**

![AddSiteFeature](images/AddSiteFeature.PNG?raw=true "AddSiteFeature")

4.  In the dialog, make sure you have selected **Location** and **Location Maps** then click OK

![FeatureLocation](images/FeatureLocation.PNG?raw=true "FeatureLocation")

5. Open the Experience Editor a you will see a new section on the Toolbox called *Location* that has a component called Location Map which you can use by dragging into you page.

![Toolbox](images/Toolbox.png?raw=true "Toolbox")


## Configuration

You don't need to configure anything else, the module is ready to be used once it's correctly installed.
No file configurations are needed. 


## Usage

### Content Editor

1. Once you have a SXA site, you will find some content items required to manage the module.

![POI](images/ExperienceEditor5.png?raw=true "POI")
	- Here you will see the Location maps you manage on your site, same as points of interests. 

2. If you take a look closer to the Location POI item, it has a Type which by default is **Marker** 

![POIType](images/POIType.png?raw=true "POIType")

3. In order to manage all the types of the POIs, go to */sitecore/content/tenant/site/Presentation/POI Types* and create a POI Type

![PoiTypeSetup](images/PoiTypeSetup.png?raw=true "PoiTypeSetup")
	- You need to add a class base on Font Awesome class name, eg. fa-map-pin. 
	- You can create as many you need. 

### Experience Editor

1. Drag the Location map and drop it into a placeholder on your page and a dialog will be displayed where you can create a new Map Location item or select an existing one. If you don't have any, select **create** 

![POI](images/ExperienceEditor1.png?raw=true "POI")

2. Another dialog will be presented where you can choose the type of item and a name, select Map Location. 

![POI](images/ExperienceEditor2.png?raw=true "POI")

3. Once you have created a Map location instance, you can now edit the item. Select the component and click on the edit button.

![POI](images/ExperienceEditor3.png?raw=true "POI")

4. A dialog will show the fields managed on this item: Image and POIs. Select an image and click ok. Save your changes 

![POI](images/ExperienceEditor4.png?raw=true "POI")

5. If you want to create a point of interest item, you can click the pin button (next to the edit button) and a dialog will be displayed where you can choose the name of the new point. 

![POI](images/ExperienceEditor51.png?raw=true "POI")

You will see the points of interest of the map as children of the item

![POI](images/ExperienceEditor5.png?raw=true "POI")

You have to select which point of interest you want to manage in the component by using the treelist of the map item

![POI](images/ExperienceEditor6.png?raw=true "POI")

7. Once you create a POI you have to save your changes and the item will be available for you to edit it and place it wherever you need. 

![POI](images/ExperienceEditor7.png?raw=true "POI")

## Video

Here is our presentation of this module.

[direct link](https://www.youtube.com/watch?v=EpNhxW4pNKk) to the video, upload it to this documentation folder or maybe upload it to Youtube...
[Sitecore Hackathon Video Embedding Alt Text](https://img.youtube.com/vi/EpNhxW4pNKk/0.jpg)](https://www.youtube.com/watch?v=EpNhxW4pNKk)
