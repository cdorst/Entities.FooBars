# Entities.FooBars

[![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/entities-foobars.svg?label=AppVeyor&style=for-the-badge)](https://ci.appveyor.com/project/cdorst/entities-foobars)
[![NuGet package status](https://img.shields.io/nuget/v/CDorst.Entities.FooBars.svg?label=NuGet&style=for-the-badge)](https://www.nuget.org/packages/CDorst.Entities.FooBars)

## Description

Contains the FooBar entity type

## Environment Variables

This project depends on this environment variable:

Name | Description
---- | -----------
`LOCAL_NUGET_SOURCE_PATH` | *Required* to build the project, but not required during code execution. This is set to `c:\projects\nuget\cache` on the build server. On your development machine, set this to an empty, existing path. `dotnet restore` will inspect this folder prior to checking NuGet.

## Dependencies

Name | Status
---- | ------
[CDorst.DevOps.Code.Entities.Metapackages.Annotations](https://github.com/CDorst/DevOps.Code.Entities.Metapackages.Annotations) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/devops-code-entities-metapackages-annotations.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/devops-code-entities-metapackages-annotations) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.DevOps.Code.Entities.Metapackages.Annotations.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.DevOps.Code.Entities.Metapackages.Annotations)
[CDorst.DevOps.Code.Entities.Interfaces.Entity](https://github.com/CDorst/DevOps.Code.Entities.Interfaces.Entity) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/devops-code-entities-interfaces-entity.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/devops-code-entities-interfaces-entity) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.DevOps.Code.Entities.Interfaces.Entity.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.DevOps.Code.Entities.Interfaces.Entity)

## Dependents

The project below uses this repository as a direct dependency.

Name | Status
---- | ------
[Entities.FooBars.DatabaseContext](https://github.com/CDorst/Entities.FooBars.DatabaseContext) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/entities-foobars-databasecontext.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/entities-foobars-databasecontext) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.Entities.FooBars.DatabaseContext.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.Entities.FooBars.DatabaseContext)

## NuGet


This project is published as a NuGet package at [https://www.nuget.org/packages/CDorst.Entities.FooBars](https://www.nuget.org/packages/CDorst.Entities.FooBars)

## Version

1.0.21

## Metaproject

Entities.FooBars is maintained by robots and exists because of a declarative template metaproject. View the metaproject's component directory at [https://github.com/CDorst/Project.Index](https://github.com/CDorst/Project.Index)

