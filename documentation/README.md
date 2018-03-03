# Location Point of Interest Documentation

![Location POI](images/LocationPOI.png?raw=true "Location POI")

## Summary

**Category:** Sitecore Experience Accelerator SxA module

This module allows editors to easily add the common "**Point of Interest (POI)**" functionality to any page. The module displays a background image with some "pinpoints" defined in Sitecore, but dynamically using Sitecore Experience Accelerator (SxA) in order to allow the editor to preview the results in real time.

## Pre-requisites

Please make sure you have the following requirements installed:

- Sitecore 9.0 rev. 171219 (Update-1).
- Sitecore Experience Accelerator Module, which requires:
	- Sitecore PowerShell Extensions 4.7.2 for Sitecore 8/9

## Installation

Please follow this instructions to install this module:

1. Use the Sitecore Installation wizard to install the [package](#link-to-package)
2. Publish
3. Enable the Feature on your existing site:
	1. Open Sitecore Content Editor
	2. Select your site:
	![SelectSite](images/SelectSite.png?raw=true "SelectSite")
	3. Right click on your site, select **Scripts**, then **Add Site Feature**
	![AddSiteFeature](images/AddSiteFeature.png?raw=true "AddSiteFeature")
	4.  In the dialog, make sure you have selected **Location** and **Location Maps** then click OK
	![FeatureLocation](images/FeatureLocation.png?raw=true "FeatureLocation")
	5. 
	
## Configuration

How do you configure your module once it is installed? Are there items that need to be updated with settings, or maybe config files need to have keys updated?

Remember you are using Markdown, you can provide code samples too:

```xml
<?xml version="1.0"?>
<!--
  Purpose: Configuration settings for my hackathon module
-->
<configuration xmlns:patch="http://www.sitecore.net/xmlconfig/">
  <sitecore>
    <settings>
      <setting name="MyModule.Setting" value="Hackathon" />
    </settings>
  </sitecore>
</configuration>
```

## Usage

Provide documentation  about your module, how do the users use your module, where are things located, what do icons mean, are there any secret shortcuts etc.

![POI](images/poi.png?raw=true "POI")

## Video

Please provide a video highlighing your Hackathon module submission and provide a link to the video. Either a [direct link](https://www.youtube.com/watch?v=EpNhxW4pNKk) to the video, upload it to this documentation folder or maybe upload it to Youtube...

[![Sitecore Hackathon Video Embedding Alt Text](https://img.youtube.com/vi/EpNhxW4pNKk/0.jpg)](https://www.youtube.com/watch?v=EpNhxW4pNKk)
