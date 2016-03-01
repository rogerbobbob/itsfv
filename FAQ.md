

# ReverseScrobble #

Main Article: ReverseScrobble

## After ReverseScrobbling my iTunes PlayedCount for Track X is not the same as Last.fm PlayedCount for Track X ##

iTSfv attempst to process all the weekly XML data in Last.fm web servers to accumulate the PlayedCount for a particular track. However during this process, timeouts could occur and iTSfv could miss one or more XML files. When this happens, iTSfv will not have the same PlayedCount as shown in Last.fm. More and more reverse scrobbling should bridge the gap between the two played counts.

# Troubleshooting #

## I upgraded iTunes and iTSfv does not start properly / getting "Object reference not set to an instance of an object" when the program starts ##

If you are having this error then please try the following:

  * Close both iTunes and iTSfv
  * Start > Run > type:
```
itunes /regserver
```
  * Press Enter
  * Start iTSfv
