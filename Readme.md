# Offline Website   

This is a simple website that displays the `OfflinePage.html` for all requests. It is used when the main website is down for some reason and you want to show a nice message to the users

## Why
Simply putting a default.htm is the root of a website only works for requests to the root domain, any requests for sub pages will get a 404 error. It also requests the browser and proxies etc do not cache it, so when the real website returns, the users see it and not a cached version of the offline page.

## Styling
As this page will be rendered under any url, ensure references to css, js and images start "/" to root them from the website root.

## TODO
Check if file exists before returning the offline page (for example css, js and images required to display the offline page)