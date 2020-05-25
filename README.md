# Singleton in Unity/Singleton en Unity

_This is a project to be used as example, where Object Pooling pattern design is implemented_

_Este es un proyecto para ser usado como ejemplo, donde se implementa el patron de diseño Singleton_


### Pre requirements/Pre-requisitos 📋

_Unity Version_

```
2019.3.5f1
```

## Preview 🛠️
_Project Preview_
_/Previsualizacion del Proyecto_

_Spawning turtles_
_/ Creando tortugas_

![](1.gif)

###  Implemented Singleton/Singleton Implementado 📋
```csharp
 public static GameEnvironment Singleton
    {
        get
        {
            if (instance == null)
            {
                instance = new GameEnvironment();
                //add all goals after create the instance
                instance.Goals.AddRange(GameObject.FindGameObjectsWithTag("goal"));
            }
            return instance;

        }
    }
```




## Expresiones de Gratitud 🎁

* Comenta a otros sobre este proyecto 📢
* Da las gracias públicamente 🤓.

