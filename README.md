# Lotto Project

[![Build Status](https://travis-ci.org/joemccann/dillinger.svg?branch=master)](https://travis-ci.org/joemccann/dillinger)

Lotto is a sample project which basically used to consume an API end point to show the results.

  - This is a code challenge to build a simple application or web page to display a Lottery Draw and jackpot information. The endpoint is: https://data.api.thelott.com/sales/vmax/web/data/lotto/opendraws 

  - The products display should at least have OZlotto, Gold Lotto and Powerball. 

  - The information display in the web page requires to at least have Lottery product display name, logo image, draw date, draw number and jackpack value (Div1Amount). 
 
  - Contains two units test ensuring the API call is valid. 


# New Features!

  - Helix structure
  -Tried to pull onion architecute with DDD pattern (Note- Still a few part is pending)


### Tech

Dillinger uses a number of open source projects to work properly:

* [MVC Framework] - Dot Net MVC
* [Unity] - Unity framework for the DI


 on GitHub.

### Installation for main application


```sh
1.open the solution in visual studio. 

2.set the Lotto.Web as the startup project. 

3.run the Application on IIS
```

### Verify  unit test cases


```sh
1.open the solution in visual studio. 

2.set the Lotto.Test as the startup project. 

3.run the Application on IIS

```

For production environments...

```sh
Change the Base url in app settings

    <add key="LottoBaseAddress" value="https://data.api.thelott.com" />
    <add key="LottoCompanyId" value="GoldenCasket"/>
```
License
----

MIT


**Free Software, Hell Yeah!**

[//]: # (These are reference links used in the body of this note and get stripped out when the markdown processor does its job. There is no need to format nicely because it shouldn't be seen. Thanks SO - http://stackoverflow.com/questions/4823468/store-comments-in-markdown-syntax)


   [dill]: <https://github.com/joemccann/dillinger>
   [git-repo-url]: <https://github.com/joemccann/dillinger.git>
   [john gruber]: <http://daringfireball.net>
   [df1]: <http://daringfireball.net/projects/markdown/>
   [markdown-it]: <https://github.com/markdown-it/markdown-it>
   [Ace Editor]: <http://ace.ajax.org>
   [node.js]: <http://nodejs.org>
   [Twitter Bootstrap]: <http://twitter.github.com/bootstrap/>
   [jQuery]: <http://jquery.com>
   [@tjholowaychuk]: <http://twitter.com/tjholowaychuk>
   [express]: <http://expressjs.com>
   [AngularJS]: <http://angularjs.org>
   [Gulp]: <http://gulpjs.com>

   [PlDb]: <https://github.com/joemccann/dillinger/tree/master/plugins/dropbox/README.md>
   [PlGh]: <https://github.com/joemccann/dillinger/tree/master/plugins/github/README.md>
   [PlGd]: <https://github.com/joemccann/dillinger/tree/master/plugins/googledrive/README.md>
   [PlOd]: <https://github.com/joemccann/dillinger/tree/master/plugins/onedrive/README.md>
   [PlMe]: <https://github.com/joemccann/dillinger/tree/master/plugins/medium/README.md>
   [PlGa]: <https://github.com/RahulHP/dillinger/blob/master/plugins/googleanalytics/README.md>
