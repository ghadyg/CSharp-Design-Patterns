<p align="center">
  <img src="https://cdn-icons-png.flaticon.com/512/6295/6295417.png" width="100" />
</p>
<p align="center">
    <h1 align="center">CSHARP-DESIGN-PATTERNS</h1>
</p>
<!-- <p align="center">
    <em><code>► INSERT-TEXT-HERE</code></em>
</p> -->
<p align="center">
	<img src="https://img.shields.io/github/license/ghadyg/CSharp-Design-Patterns?style=flat&color=0080ff" alt="license">
	<img src="https://img.shields.io/github/last-commit/ghadyg/CSharp-Design-Patterns?style=flat&logo=git&logoColor=white&color=0080ff" alt="last-commit">
	<img src="https://img.shields.io/github/languages/top/ghadyg/CSharp-Design-Patterns?style=flat&color=0080ff" alt="repo-top-language">
	<img src="https://img.shields.io/github/languages/count/ghadyg/CSharp-Design-Patterns?style=flat&color=0080ff" alt="repo-language-count">
<p>
<!-- <p align="center">
		<em>Developed with the software and tools below.</em>
</p> -->
<!-- <p align="center">
	<img src="https://img.shields.io/badge/EditorConfig-FEFEFE.svg?style=flat&logo=EditorConfig&logoColor=black" alt="EditorConfig">
	<img src="https://img.shields.io/badge/JSON-000000.svg?style=flat&logo=JSON&logoColor=white" alt="JSON">
</p> -->
<hr>

##  Quick Links

> - [ Overview](#-overview)
> - [ Features](#-features)
> - [ Repository Structure](#-repository-structure)
> - [ Modules](#-modules)
> - [ Getting Started](#-getting-started)
>   - [ Installation](#-installation)
>   - [ Running CSharp-Design-Patterns](#-running-CSharp-Design-Patterns)
> - [ License](#-license)


---

##  Overview

<code>This project was developed as part of a design pattern course, where it received a high score of 85/100. It is a restaurant application designed to streamline the process of ordering food from restaurants.

Users can browse through a selection of available food items, choose the items they want to purchase, specify the quantity, and complete the purchase seamlessly within the application.</code>

---

##  Features

<code><b>Abstract Factory:</b> Used to provide an interface for creating families of related or dependent objects without specifying their concrete classes. In this application, it was utilized to create a template menu to be used by all restaurants, ensuring consistency and ease of management.
<b>Factory Method:</b> Implemented to define an interface for creating an object, but allowing subclasses to alter the type of objects that will be created. Here, it was used to create restaurants with the same attributes (e.g., name, rating, address) but with different values, thereby accommodating variations among different restaurants.
<b>Decorator: </b>Utilized to dynamically add new functionalities to objects without altering their structure. In this application, it was used to customize sandwiches by adding ingredients and updating the price accordingly.
<b>NotificationBaseSender:</b> Implemented to provide a base class for sending notifications, allowing for easy extension and customization of notification-sending functionalities.</code>

---

##  Repository Structure

```sh
└── CSharp-Design-Patterns/
    ├── App
    │   ├── AFMenu
    │   │   └── IMenuFactory.cs
    │   ├── APMenu
    │   │   └── Menu.cs
    │   ├── App.csproj
    │   ├── App.csproj.user
    │   ├── BledorForm.Designer.cs
    │   ├── BledorForm.cs
    │   ├── BledorForm.resx
    │   ├── CCSandwich
    │   │   ├── BeefSandwich.cs
    │   │   ├── ChickenSandwich.cs
    │   │   └── TunaSandwich.cs
    │   ├── CDSandwich
    │   │   ├── Cheese.cs
    │   │   ├── bacon.cs
    │   │   ├── sauce.cs
    │   │   └── tomato.cs
    │   ├── CFMenu
    │   │   ├── BledorMenu.cs
    │   │   ├── MiniBMenu.cs
    │   │   └── PizzeriaMenu.cs
    │   ├── CFRestaurent
    │   │   ├── RestaurentBurger.cs
    │   │   ├── RestaurentDessert.cs
    │   │   ├── RestaurentPizza.cs
    │   │   └── RestaurentSub.cs
    │   ├── CPMenu
    │   │   ├── BledorSaltM.cs
    │   │   ├── BledorSweetM.cs
    │   │   ├── MiniBSaltM.cs
    │   │   ├── MiniBSweetM.cs
    │   │   ├── PizzeriaSaltM.cs
    │   │   └── PizzeriaSweetM.cs
    │   ├── CPRestaurent
    │   │   ├── MiniB.cs
    │   │   ├── Pizzeria.cs
    │   │   ├── Subway.cs
    │   │   └── bledor.cs
    │   ├── CSandwich
    │   │   └── Sandwich.cs
    │   ├── DSandwich
    │   │   └── SandwichAddon.cs
    │   ├── EmailNotificationSender.cs
    │   ├── FBRestaurent
    │   │   └── IRestaurentFactory.cs
    │   ├── Food.cs
    │   ├── Message.cs
    │   ├── MessageNotificationSender.cs
    │   ├── MiniBForm.Designer.cs
    │   ├── MiniBForm.cs
    │   ├── MiniBForm.resx
    │   ├── NotificatonBaseSender
    │   │   └── NotificationSenderBase.cs
    │   ├── OrderForm.Designer.cs
    │   ├── OrderForm.cs
    │   ├── OrderForm.resx
    │   ├── PBRestaurent
    │   │   └── Restaurent.cs
    │   ├── Person.cs
    │   ├── PizzeriaForm.Designer.cs
    │   ├── PizzeriaForm.cs
    │   ├── PizzeriaForm.resx
    │   ├── Program.cs
    │   ├── Properties
    │   │   ├── Resources.Designer.cs
    │   │   └── Resources.resx
    │   ├── RInterface.Designer.cs
    │   ├── RInterface.cs
    │   ├── RInterface.resx
    │   ├── Resources
    │   │   ├── Pizzeria-logo.jpg
    │   │   ├── Samsung - Notification Tone.wav
    │   │   ├── bledor-logo.png
    │   │   ├── logo-burger.jpg
    │   │   ├── samsung_letter.wav
    │   │   └── subway-logo.jpg
    │   ├── SubwayForm.Designer.cs
    │   ├── SubwayForm.cs
    │   ├── SubwayForm.resx
    │   ├── bin
    │   │   └── Debug
    │   │       ├── net5.0-windows
    │   │       │   ├── App.deps.json
    │   │       │   ├── App.dll
    │   │       │   ├── App.exe
    │   │       │   ├── App.pdb
    │   │       │   ├── App.runtimeconfig.dev.json
    │   │       │   ├── App.runtimeconfig.json
    │   │       │   └── ref
    │   │       └── net7.0-windows
    │   │           ├── App.deps.json
    │   │           ├── App.dll
    │   │           ├── App.exe
    │   │           ├── App.pdb
    │   │           └── App.runtimeconfig.json
    │   └── obj
    │       ├── App.csproj.nuget.dgspec.json
    │       ├── App.csproj.nuget.g.props
    │       ├── App.csproj.nuget.g.targets
    │       ├── Debug
    │       │   ├── net5.0-windows
    │       │   │   ├── .NETCoreApp,Version=v5.0.AssemblyAttributes.cs
    │       │   │   ├── App.AssemblyInfo.cs
    │       │   │   ├── App.AssemblyInfoInputs.cache
    │       │   │   ├── App.BledorForm.resources
    │       │   │   ├── App.GeneratedMSBuildEditorConfig.editorconfig
    │       │   │   ├── App.MiniBForm.resources
    │       │   │   ├── App.OrderForm.resources
    │       │   │   ├── App.PizzeriaForm.resources
    │       │   │   ├── App.Properties.Resources.resources
    │       │   │   ├── App.RInterface.resources
    │       │   │   ├── App.SubwayForm.resources
    │       │   │   ├── App.assets.cache
    │       │   │   ├── App.csproj.AssemblyReference.cache
    │       │   │   ├── App.csproj.CoreCompileInputs.cache
    │       │   │   ├── App.csproj.FileListAbsolute.txt
    │       │   │   ├── App.csproj.GenerateResource.cache
    │       │   │   ├── App.designer.deps.json
    │       │   │   ├── App.designer.runtimeconfig.json
    │       │   │   ├── App.dll
    │       │   │   ├── App.genruntimeconfig.cache
    │       │   │   ├── App.pdb
    │       │   │   ├── TempPE
    │       │   │   ├── apphost.exe
    │       │   │   └── ref
    │       │   └── net7.0-windows
    │       │       ├── .NETCoreApp,Version=v7.0.AssemblyAttributes.cs
    │       │       ├── App.AssemblyInfo.cs
    │       │       ├── App.AssemblyInfoInputs.cache
    │       │       ├── App.BledorForm.resources
    │       │       ├── App.GeneratedMSBuildEditorConfig.editorconfig
    │       │       ├── App.MiniBForm.resources
    │       │       ├── App.OrderForm.resources
    │       │       ├── App.PizzeriaForm.resources
    │       │       ├── App.Properties.Resources.resources
    │       │       ├── App.RInterface.resources
    │       │       ├── App.SubwayForm.resources
    │       │       ├── App.assets.cache
    │       │       ├── App.csproj.BuildWithSkipAnalyzers
    │       │       ├── App.csproj.CoreCompileInputs.cache
    │       │       ├── App.csproj.FileListAbsolute.txt
    │       │       ├── App.csproj.GenerateResource.cache
    │       │       ├── App.designer.deps.json
    │       │       ├── App.designer.runtimeconfig.json
    │       │       ├── App.dll
    │       │       ├── App.genruntimeconfig.cache
    │       │       ├── App.pdb
    │       │       ├── apphost.exe
    │       │       ├── ref
    │       │       └── refint
    │       ├── project.assets.json
    │       └── project.nuget.cache
    └── App.sln
```

---

##  Modules

<details closed><summary>.</summary>

| File                                                                            | Summary                         |
| ---                                                                             | ---                             |
| [App.sln](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App.sln) | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>App</summary>

| File                                                                                                                          | Summary                         |
| ---                                                                                                                           | ---                             |
| [SubwayForm.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/SubwayForm.cs)                               | <code>► INSERT-TEXT-HERE</code> |
| [RInterface.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/RInterface.cs)                               | <code>► INSERT-TEXT-HERE</code> |
| [SubwayForm.resx](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/SubwayForm.resx)                           | <code>► INSERT-TEXT-HERE</code> |
| [Food.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/Food.cs)                                           | <code>► INSERT-TEXT-HERE</code> |
| [RInterface.Designer.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/RInterface.Designer.cs)             | <code>► INSERT-TEXT-HERE</code> |
| [EmailNotificationSender.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/EmailNotificationSender.cs)     | <code>► INSERT-TEXT-HERE</code> |
| [RInterface.resx](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/RInterface.resx)                           | <code>► INSERT-TEXT-HERE</code> |
| [BledorForm.resx](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/BledorForm.resx)                           | <code>► INSERT-TEXT-HERE</code> |
| [PizzeriaForm.resx](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/PizzeriaForm.resx)                       | <code>► INSERT-TEXT-HERE</code> |
| [SubwayForm.Designer.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/SubwayForm.Designer.cs)             | <code>► INSERT-TEXT-HERE</code> |
| [OrderForm.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/OrderForm.cs)                                 | <code>► INSERT-TEXT-HERE</code> |
| [App.csproj.user](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/App.csproj.user)                           | <code>► INSERT-TEXT-HERE</code> |
| [PizzeriaForm.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/PizzeriaForm.cs)                           | <code>► INSERT-TEXT-HERE</code> |
| [OrderForm.Designer.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/OrderForm.Designer.cs)               | <code>► INSERT-TEXT-HERE</code> |
| [App.csproj](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/App.csproj)                                     | <code>► INSERT-TEXT-HERE</code> |
| [BledorForm.Designer.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/BledorForm.Designer.cs)             | <code>► INSERT-TEXT-HERE</code> |
| [MessageNotificationSender.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/MessageNotificationSender.cs) | <code>► INSERT-TEXT-HERE</code> |
| [Message.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/Message.cs)                                     | <code>► INSERT-TEXT-HERE</code> |
| [MiniBForm.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/MiniBForm.cs)                                 | <code>► INSERT-TEXT-HERE</code> |
| [Person.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/Person.cs)                                       | <code>► INSERT-TEXT-HERE</code> |
| [MiniBForm.Designer.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/MiniBForm.Designer.cs)               | <code>► INSERT-TEXT-HERE</code> |
| [OrderForm.resx](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/OrderForm.resx)                             | <code>► INSERT-TEXT-HERE</code> |
| [Program.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/Program.cs)                                     | <code>► INSERT-TEXT-HERE</code> |
| [MiniBForm.resx](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/MiniBForm.resx)                             | <code>► INSERT-TEXT-HERE</code> |
| [BledorForm.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/BledorForm.cs)                               | <code>► INSERT-TEXT-HERE</code> |
| [PizzeriaForm.Designer.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/PizzeriaForm.Designer.cs)         | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>App.FBRestaurent</summary>

| File                                                                                                                         | Summary                         |
| ---                                                                                                                          | ---                             |
| [IRestaurentFactory.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/FBRestaurent/IRestaurentFactory.cs) | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>App.AFMenu</summary>

| File                                                                                                       | Summary                         |
| ---                                                                                                        | ---                             |
| [IMenuFactory.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/AFMenu/IMenuFactory.cs) | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>App.CFRestaurent</summary>

| File                                                                                                                       | Summary                         |
| ---                                                                                                                        | ---                             |
| [RestaurentSub.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/CFRestaurent/RestaurentSub.cs)         | <code>► INSERT-TEXT-HERE</code> |
| [RestaurentBurger.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/CFRestaurent/RestaurentBurger.cs)   | <code>► INSERT-TEXT-HERE</code> |
| [RestaurentDessert.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/CFRestaurent/RestaurentDessert.cs) | <code>► INSERT-TEXT-HERE</code> |
| [RestaurentPizza.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/CFRestaurent/RestaurentPizza.cs)     | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>App.DSandwich</summary>

| File                                                                                                            | Summary                         |
| ---                                                                                                             | ---                             |
| [SandwichAddon.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/DSandwich/SandwichAddon.cs) | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>App.obj</summary>

| File                                                                                                                              | Summary                         |
| ---                                                                                                                               | ---                             |
| [App.csproj.nuget.g.targets](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/obj/App.csproj.nuget.g.targets)     | <code>► INSERT-TEXT-HERE</code> |
| [App.csproj.nuget.g.props](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/obj/App.csproj.nuget.g.props)         | <code>► INSERT-TEXT-HERE</code> |
| [App.csproj.nuget.dgspec.json](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/obj/App.csproj.nuget.dgspec.json) | <code>► INSERT-TEXT-HERE</code> |
| [project.assets.json](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/obj/project.assets.json)                   | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>App.obj.Debug.net5.0-windows</summary>

| File                                                                                                                                                                                       | Summary                         |
| ---                                                                                                                                                                                        | ---                             |
| [App.AssemblyInfo.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/obj/Debug/net5.0-windows/App.AssemblyInfo.cs)                                                       | <code>► INSERT-TEXT-HERE</code> |
| [App.csproj.FileListAbsolute.txt](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/obj/Debug/net5.0-windows/App.csproj.FileListAbsolute.txt)                               | <code>► INSERT-TEXT-HERE</code> |
| [App.designer.deps.json](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/obj/Debug/net5.0-windows/App.designer.deps.json)                                                 | <code>► INSERT-TEXT-HERE</code> |
| [App.GeneratedMSBuildEditorConfig.editorconfig](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/obj/Debug/net5.0-windows/App.GeneratedMSBuildEditorConfig.editorconfig)   | <code>► INSERT-TEXT-HERE</code> |
| [App.designer.runtimeconfig.json](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/obj/Debug/net5.0-windows/App.designer.runtimeconfig.json)                               | <code>► INSERT-TEXT-HERE</code> |
| [.NETCoreApp,Version=v5.0.AssemblyAttributes.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/obj/Debug/net5.0-windows/.NETCoreApp,Version=v5.0.AssemblyAttributes.cs) | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>App.obj.Debug.net7.0-windows</summary>

| File                                                                                                                                                                                       | Summary                         |
| ---                                                                                                                                                                                        | ---                             |
| [App.AssemblyInfo.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/obj/Debug/net7.0-windows/App.AssemblyInfo.cs)                                                       | <code>► INSERT-TEXT-HERE</code> |
| [App.csproj.FileListAbsolute.txt](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/obj/Debug/net7.0-windows/App.csproj.FileListAbsolute.txt)                               | <code>► INSERT-TEXT-HERE</code> |
| [App.designer.deps.json](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/obj/Debug/net7.0-windows/App.designer.deps.json)                                                 | <code>► INSERT-TEXT-HERE</code> |
| [App.GeneratedMSBuildEditorConfig.editorconfig](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/obj/Debug/net7.0-windows/App.GeneratedMSBuildEditorConfig.editorconfig)   | <code>► INSERT-TEXT-HERE</code> |
| [.NETCoreApp,Version=v7.0.AssemblyAttributes.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/obj/Debug/net7.0-windows/.NETCoreApp,Version=v7.0.AssemblyAttributes.cs) | <code>► INSERT-TEXT-HERE</code> |
| [App.designer.runtimeconfig.json](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/obj/Debug/net7.0-windows/App.designer.runtimeconfig.json)                               | <code>► INSERT-TEXT-HERE</code> |
| [App.csproj.BuildWithSkipAnalyzers](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/obj/Debug/net7.0-windows/App.csproj.BuildWithSkipAnalyzers)                           | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>App.APMenu</summary>

| File                                                                                       | Summary                         |
| ---                                                                                        | ---                             |
| [Menu.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/APMenu/Menu.cs) | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>App.PBRestaurent</summary>

| File                                                                                                         | Summary                         |
| ---                                                                                                          | ---                             |
| [Restaurent.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/PBRestaurent/Restaurent.cs) | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>App.CPRestaurent</summary>

| File                                                                                                     | Summary                         |
| ---                                                                                                      | ---                             |
| [Pizzeria.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/CPRestaurent/Pizzeria.cs) | <code>► INSERT-TEXT-HERE</code> |
| [bledor.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/CPRestaurent/bledor.cs)     | <code>► INSERT-TEXT-HERE</code> |
| [MiniB.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/CPRestaurent/MiniB.cs)       | <code>► INSERT-TEXT-HERE</code> |
| [Subway.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/CPRestaurent/Subway.cs)     | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>App.CDSandwich</summary>

| File                                                                                               | Summary                         |
| ---                                                                                                | ---                             |
| [tomato.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/CDSandwich/tomato.cs) | <code>► INSERT-TEXT-HERE</code> |
| [sauce.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/CDSandwich/sauce.cs)   | <code>► INSERT-TEXT-HERE</code> |
| [bacon.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/CDSandwich/bacon.cs)   | <code>► INSERT-TEXT-HERE</code> |
| [Cheese.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/CDSandwich/Cheese.cs) | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>App.NotificatonBaseSender</summary>

| File                                                                                                                                          | Summary                         |
| ---                                                                                                                                           | ---                             |
| [NotificationSenderBase.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/NotificatonBaseSender/NotificationSenderBase.cs) | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>App.CFMenu</summary>

| File                                                                                                       | Summary                         |
| ---                                                                                                        | ---                             |
| [BledorMenu.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/CFMenu/BledorMenu.cs)     | <code>► INSERT-TEXT-HERE</code> |
| [PizzeriaMenu.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/CFMenu/PizzeriaMenu.cs) | <code>► INSERT-TEXT-HERE</code> |
| [MiniBMenu.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/CFMenu/MiniBMenu.cs)       | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>App.bin.Debug.net5.0-windows</summary>

| File                                                                                                                                               | Summary                         |
| ---                                                                                                                                                | ---                             |
| [App.deps.json](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/bin/Debug/net5.0-windows/App.deps.json)                           | <code>► INSERT-TEXT-HERE</code> |
| [App.runtimeconfig.json](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/bin/Debug/net5.0-windows/App.runtimeconfig.json)         | <code>► INSERT-TEXT-HERE</code> |
| [App.runtimeconfig.dev.json](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/bin/Debug/net5.0-windows/App.runtimeconfig.dev.json) | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>App.bin.Debug.net7.0-windows</summary>

| File                                                                                                                                       | Summary                         |
| ---                                                                                                                                        | ---                             |
| [App.deps.json](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/bin/Debug/net7.0-windows/App.deps.json)                   | <code>► INSERT-TEXT-HERE</code> |
| [App.runtimeconfig.json](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/bin/Debug/net7.0-windows/App.runtimeconfig.json) | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>App.Properties</summary>

| File                                                                                                                       | Summary                         |
| ---                                                                                                                        | ---                             |
| [Resources.resx](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/Properties/Resources.resx)               | <code>► INSERT-TEXT-HERE</code> |
| [Resources.Designer.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/Properties/Resources.Designer.cs) | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>App.CCSandwich</summary>

| File                                                                                                                 | Summary                         |
| ---                                                                                                                  | ---                             |
| [ChickenSandwich.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/CCSandwich/ChickenSandwich.cs) | <code>► INSERT-TEXT-HERE</code> |
| [BeefSandwich.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/CCSandwich/BeefSandwich.cs)       | <code>► INSERT-TEXT-HERE</code> |
| [TunaSandwich.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/CCSandwich/TunaSandwich.cs)       | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>App.CSandwich</summary>

| File                                                                                                  | Summary                         |
| ---                                                                                                   | ---                             |
| [Sandwich.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/CSandwich/Sandwich.cs) | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>App.CPMenu</summary>

| File                                                                                                           | Summary                         |
| ---                                                                                                            | ---                             |
| [BledorSweetM.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/CPMenu/BledorSweetM.cs)     | <code>► INSERT-TEXT-HERE</code> |
| [MiniBSaltM.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/CPMenu/MiniBSaltM.cs)         | <code>► INSERT-TEXT-HERE</code> |
| [BledorSaltM.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/CPMenu/BledorSaltM.cs)       | <code>► INSERT-TEXT-HERE</code> |
| [PizzeriaSweetM.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/CPMenu/PizzeriaSweetM.cs) | <code>► INSERT-TEXT-HERE</code> |
| [MiniBSweetM.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/CPMenu/MiniBSweetM.cs)       | <code>► INSERT-TEXT-HERE</code> |
| [PizzeriaSaltM.cs](https://github.com/ghadyg/CSharp-Design-Patterns/blob/master/App/CPMenu/PizzeriaSaltM.cs)   | <code>► INSERT-TEXT-HERE</code> |

</details>

---

##  Getting Started

###  Installation

1. Clone the CSharp-Design-Patterns repository:

```sh
git clone https://github.com/ghadyg/CSharp-Design-Patterns
```

2. Change to the project directory:
```sh
cd CSharp-Design-Patterns
```
3. Open the solution
```sh
App.sln
```
### Running CSharp-Design-Patterns
1. Change to the project directory:
```sh
cd CSharp-Design-Patterns\App\App\bin\Debug\net7.0-windows
```
2. Run the App:
```sh
App.exe
```

