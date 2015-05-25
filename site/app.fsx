#r "packages/Suave/lib/net40/Suave.dll"

open System
open System.IO
open Suave
open Suave.Web
open Suave.Http
open Suave.Types

let app = Successful.OK("Hello World! It's Suave.io on Azure Websites.<br /><ul>" + 
          "<li>Sample git Repo: <a href='https://github.com/shanselman/suavebootstrapper'>https://github.com/shanselman/suavebootstrapper</a></li>" +
          "<li>Intro blog post: <a href='http://www.hanselman.com/blog/RunningSuaveioAndFWithFAKEInAzureWebAppsWithGitAndTheDeployButton.aspx'>http://www.hanselman.com/blog/RunningSuaveioAndFWithFAKEInAzureWebAppsWithGitAndTheDeployButton.aspx</a></li>" +
          "<li>Setting is: " + Environment.GetEnvironmentVariable("APPSETTING_USER_NAME") + 
          "</ul>")
