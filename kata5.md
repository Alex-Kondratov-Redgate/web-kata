# React App Kata 5

Code for **Kata 5** is available in the [app5](app5) folder.

## Learning aims

Up to now all data work has used the `data.js` file to focus on frontend work.
We are now moving the data to a backend server ins [aspnet core](https://www.microsoft.com/net/core).

The idea here is to learn how a web app can interact with a backend server through REST API calls.

## Requirements

* [dotnet core v2.0](https://www.microsoft.com/net/core)

## Get started

You will need **2** terminals

1. Web API server
    * go to `./app5`
    * verify dotnet version `dotnet --version` is `2.0.0`
    * run `dotnet restore`
    * run `dotnet build`
    * run `dotnet run`

    This should build the web api server and serve it at `http:\\localhost:5000`
1. Web app

* in another terminal
* go to `./app5/app/`
* follow the instructions in the [README](README.md#run-the-app).
* your app should be running at port **3000**

## Task

You are given a server that exposes the following `REST` endpoints.

|description| method | api call | notes
|---|----|---|----|
|list all products| `GET` | `http:localhost:3000/api/products/get`||
|delete product| `DELETE`| `http:localhost:3000/api/products/delete/readyroll`||
|add product| `POST` | `http:localhost:3000/api/products/add` | `json/application` with body `{name: 'product1', description: 'product description here'}`|

**Note:** there is a proxy between the web server(port `5000`) and the app server (port `3000`) so that in the app you can use `/api/products/get`. This then gets resolved to `localhost:5000/api/products/get` behind the scenes.

Write the JavaScript/React code to:

1. List all products in home page when the app is loaded using the REST api.
    * you can use technologies like [fetch](https://github.github.io/fetch/) or [jQuery.ajax](http://api.jquery.com/jquery.ajax/)
    * to add a package do [yarn add](https://yarnpkg.com/lang/en/docs/cli/add/)
    * eg: `yarn add whatwg-fetch`
    * after this you should be able to
        * Navigate to each product page
        * Have hard links on products names
1. Add a remove button so that the user can remove a product from the list
    * you should use the REST api for this, `/api/products/delete/productname` (see above for details)
1. Add a form so that user is able to add a new product to the list.
    * you should use the REST api for thism `/api/products/add` (see above for details)
1. Changes to the data should persist through sessions:
    * delete a product
    * add a product
    * open a new tab with the app
    * verify the removed product is not present
    * verify the added product is present

## Resources

* [github fetch](https://github.com/github/fetch)
* [fetch docs](https://github.github.io/fetch/)