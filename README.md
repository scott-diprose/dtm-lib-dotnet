# dp-metadata

Basic library implementing scott-diprose/dp-metadata

NOTE: Currently only available on the development branch.

---

Metadata to describes processes within a data pipeline.

Canonical model provided as a JSON Schema.

Note this class lib is intended as a serialisation library, and not domain objects. As such all classes are immutable. Domain objects belong in the realm of the individual tools. Noting they may also implement the interfaces through their own class library for serialisation.


# dp-metadata.net

Object model for standardising the structure of metadata applicable to data pipelines, implemented in .NET Core.
The intention is to enable loose coupling between tools or components. Allowing for the construction of pipelines using compliant tools, without lock-in to a specific tool set.


https://dzone.com/articles/c-interfaces-what-are-they-and
https://www.dotnetcurry.com/patterns-practices/1429/data-objects-csharp-fsharp
https://www.dotnetcurry.com/patterns-practices/1367/data-encapsulation-large-csharp-applications
https://blog.ploeh.dk/2011/07/28/CompositionRoot/
https://blog.ploeh.dk/2012/07/02/PrimitiveDependencies/




# dp-metadata.js


# dp-metadata.py

