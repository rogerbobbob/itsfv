
# Requirements #

  * Portable Archive (requires JRE 1.4.1 or higher, no Explorer integration) from http://www.syntevo.com/smartsvn/download.html
  * Google Code Password from http://code.google.com/hosting/settings
  * Latest iTunes
  * Visual Studio 2008

# Setting up SmartSVN #

## What you want to do? ##
![http://i38.tinypic.com/oi5cgk.png](http://i38.tinypic.com/oi5cgk.png)

## Check out Project ##
![http://i37.tinypic.com/v5agxh.png](http://i37.tinypic.com/v5agxh.png)

  1. Click Manage
  1. Click Add in Repository Files

### Add Repository File ###
![http://i36.tinypic.com/1127fpy.png](http://i36.tinypic.com/1127fpy.png)

  * Enter SVN URL
```
https://itsfv.googlecode.com/svn
```

![http://i35.tinypic.com/16bn69d.png](http://i35.tinypic.com/16bn69d.png)

  * Press OK
  * Now Add Repository file will look like:
![http://i36.tinypic.com/eld89u.png](http://i36.tinypic.com/eld89u.png)
  * Press Next
  * Enter Google UserName and Google Code Password
![http://i36.tinypic.com/24159o1.png](http://i36.tinypic.com/24159o1.png)
  * Accept Server Finger Print
![http://i37.tinypic.com/2mmwr9f.png](http://i37.tinypic.com/2mmwr9f.png)
  * Click Finish


Now we are back to Check out Project
![http://i33.tinypic.com/t7yb7d.png](http://i33.tinypic.com/t7yb7d.png)

  * Press Next
  * Select **trunk** folder
![http://i34.tinypic.com/10nf6t3.png](http://i34.tinypic.com/10nf6t3.png)
  * Press Next
  * Create folder path
```
Visual Studio 2008\Projects\Google Code\iTSfv\trunk
```
This is the suggested folder path; you may have any folder path you wish. However satisfying at least folder hierarchy below is recommended.
```
iTSfv\trunk
```

![http://i37.tinypic.com/2hmhjc9.png](http://i37.tinypic.com/2hmhjc9.png)
  * Select the **trunk** folder
![http://i34.tinypic.com/2n1rlm8.png](http://i34.tinypic.com/2n1rlm8.png)
  * Press Next
  * Rename 'trunk' to iTSfv
![http://i33.tinypic.com/fxzcxd.png](http://i33.tinypic.com/fxzcxd.png)
  * Press Finish
![http://i35.tinypic.com/2e2noud.png](http://i35.tinypic.com/2e2noud.png)

SmartSVN will be now checking out source
![http://i37.tinypic.com/xf6ik0.png](http://i37.tinypic.com/xf6ik0.png)
After SmartSVN is down checking source
![http://wmwiki.com/mcored/screenshots/iTSfv_-_SmartSVN_Professional_5_demo_until_02092009-20090205103735.png](http://wmwiki.com/mcored/screenshots/iTSfv_-_SmartSVN_Professional_5_demo_until_02092009-20090205103735.png)
close SmartSVN.

# Using Visual Studio #
  * Double click the Visual Studio Solution file
![http://wmwiki.com/mcored/screenshots/trunk-20090205103634.png](http://wmwiki.com/mcored/screenshots/trunk-20090205103634.png)
  * Press Play button in the toolbar
![http://wmwiki.com/mcored/screenshots/iTSfv_-_Microsoft_Visual_Studio-20090205103841.png](http://wmwiki.com/mcored/screenshots/iTSfv_-_Microsoft_Visual_Studio-20090205103841.png)
  * You will be running iTSfv from source. About Window of iTSfv:
![http://wmwiki.com/mcored/screenshots/About_iTSfv-20090205104030.png](http://wmwiki.com/mcored/screenshots/About_iTSfv-20090205104030.png)
  * You can insert break points and debug iTSfv.
  * If you would like to join the development by committing source, please leave a comment in this page.