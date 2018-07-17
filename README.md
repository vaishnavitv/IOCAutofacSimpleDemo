# IOCAutofacSimpleDemo
 Managing Dependency Injection in C# with Autofac 
 
 ccording to Wikipedia the Dependency Inversion Principle (popularized by Robert Martin) states that:

    High-level modules should not depend upon low-level modules. Both should depend upon abstractions.
    Abstractions should not depend upon details. Details should depend upon abstractions.

In traditional architecture “Higher” level modules depend on “lower” level modules.
If we think in terms of an application with a presentation layer, an application layer, a business layer, and a data layer.
The Presentation layer is the highest layer and traditionally depends directly upon and may communicate directly with the Application layer. The application layer is a higher level layer than the Business layer and traditionally depends upon and communicates directly with the business layer and so on.


When the Dependency Inversion Principle is applied this relationship is reversed. The presentation layer defines the abstractions it needs to interact with an application layer. The application layer defines the abstractions it needs from a business layer and the business layer defines the abstractions it needs from a data access layer. That is a key departure from the more classic approach, the higher layer defines the abstractions it needs to do its job and the lower layers implement those abstractions.

A strict application of the Dependency Inversion principle may even put the abstractions in the layer defining them, for example the presentation layer contains the presentation logic and application layer abstractions (abstract classes or Interfaces), and the Application assembly contains application logic and business layer abstractions and so on. In this application of the principle the Data access layer depends upon the business layer, the business layer depends upon the application layer and the application layer depends upon the presentation layer. The dependencies (references) have been inverted thus the name of the principle.
