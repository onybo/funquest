// --------------------------------------------------------------------------------------
// Start the 'app' WebPart defined in 'app.fsx' on Azure using %HTTP_PLATFORM_PORT%
// --------------------------------------------------------------------------------------

#r "../packages/FAKE/tools/FakeLib.dll"

#load "app.fsx"
open App
open Fake
open System
open Suave
open System.Net

let serverConfig =
  let port = getBuildParamOrDefault "port" "8083" |> Sockets.Port.Parse
  { Web.defaultConfig with
      homeFolder = Some __SOURCE_DIRECTORY__
      logger = Logging.Loggers.saneDefaultsFor Logging.LogLevel.Warn
      bindings = [ Types.HttpBinding.mk' Types.HTTP IPAddress.Loopback port ] }

Web.startWebServer serverConfig app
