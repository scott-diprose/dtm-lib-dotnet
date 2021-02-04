# dpmlib.net

Data Processing Metadata Library (dpmlib)

Basic .NET library implementing scott-diprose/dp-metadata

---

Metadata to describes processes within a data pipeline.

Canonical model provided as a JSON Schema.

Note this class lib is intended as a serialisation library, and not domain objects. As such all classes are immutable. Domain objects belong in the realm of the individual tools. Noting they may also implement the interfaces through their own class library for serialisation.

Object model for standardising the structure of metadata applicable to data pipelines, implemented in .NET Core.
The intention is to enable loose coupling between tools or components. Allowing for the construction of pipelines using compliant tools, without lock-in to a specific tool set.

# Release Artefacts

- dpmlib.net.dll
  .NET library for working with data processing metadata.
  
TODO:
- dpmlib-tmpl8.net.dll
  .NET library for applying object model to handle bars templates.
- dpmlib.exe
  Command line interface providing access to the above two libraries.
