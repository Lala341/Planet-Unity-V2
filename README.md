# Unknow Planet

## Intrucciones de ejecución

La información de scripts y assets se encuentra comprimida en un paquete en la carpeta raiz llamado Project 1- Package.unitypackage


## Desarrollo

Esta animación representa un planeta mágico de un solo habitante. La animación esta compuesta de 8 objetos únicos. Cada uno realizado con primitivas. 


### Generalidades


El planeta es el punto de referencia principal del objeto que representa el punto de referencia de cada objeto, es decir, cada objeto tiene un punto de refencia principal, usado para rotar, mover y escalar el objeto sin distorcionarlo. Estos puntos de cada objeto se relacionan direactamente con el planeta para lograr la rotación. Solo existen 3 objetos bajo el sistema de coordenadas globales: planeta y dos estrellas del espacio. 

Como se puede visualizar en la estructura de objetos: cada punto de referencia por objeto tiene anidados sus componentes.



Primitivas


Las primitivas que se usaron fueron: esferas, cubos, cilindros, capsulas y por último, se añade una piramide realizada en Mesh.



### Descripción de elementos y sus movimientos


#### Planeta

El primer elemento y el más grande es el planeta, padre de la mayoría de elementos. El planeta fue realizado con una esfera de color azul. Sus hijos son: Esfera de color verde para hacer la parte del planeta con suelo verde, árboles, montañas, nubes, persona, bote, y peces. 



Como se puede ver su código se crea una esfera, se asigna el nombre para que los demás elementos en diferentes scripts puedan llamarlo y se configura su posición, rotación y escala.


##### Transformadas y Sistema de coordenadas

Todos los elementos a excepción de las estrellas están anidados en el planeta. Este y las estrellas son los únicos elementos en la animación que utilizan coordenadas globales. De igual manera, el elemento en cada actualización rota en un ángulo de 15 grados, como se puede ver en el código para asemejar el moviemiento del planeta y que la cámara pueda mostrar todos los elementos del planeta.


#### Persona

La persona representada esta compuesta por 6 piramides de 3 lados, y un cubo. El diseño de esta fue inspirado en el tangram, de igual manera, la posición  y la forma de las piernas tiene como objetivo mostrar a una persona feliz que corre a través de su planeta. La distribución son 2 píramides para 

##### Transformadas y Sistema de coordenadas

Todos los elementos que componen a la persona tienen coordenads locales, la parte del abdomen o el triángulo señalado en la imagen es el padre de los demás elementos y el único hijo directo del planeta. De esta manera el objeto se mueve cuando la tierra gira. 


#### Montañas


Las montañas son un conjunto de piramides, todas relacionadas a una piramide mayor, en otras palabras, son hijas y tienen coordenadas locales respecto al centro de esta. El código muestra como se crea un piramide y se envia al método de creación de objetos locales que los asocia con la primera piramide.

##### Transformadas y Sistema de coordenadas

Todos los elementos que componen a la persona tienen coordenads locales, esto varia en el punto de referencia. La montaña principal tiene como referencia el planeta y las demás piramides tienen a la piramide mayor como punto de referencia.


#### Árboles

Los árboles fueron realizados con dos piramides y un cubo como tronco. El elemento principal que asocia los demás elementos en el árbol es el tronco. En otras palabras, las dos piramides como foliaje son hijas del elemento padre como se ve en la imagen. De igual manera el tallo tiene coordenadas locales pero respecto al planeta.


#### Bote

El bote esta compuesto por 3 cubos, un cilindro y dos piramides. El objeto de referencia es el cilindro que hace las veces de palo de soporte para las velas(piramides alargadas), para hacer los bordes del bote se utilizan cubos rotados. El cilindro tiene como punto de referencia el planeta logrando que se mueva en la rotación de este.


#### Nubes

Las nubes estan formadas por 4 capsulas, organizadas. La central sirve como punto de referencia para las demás, y este a su vez tiene como punto de refencia el planeta ya que se mueve en la rotación de este.


#### Estrellas 

Las estrellas estan formadas por 4 piramides, el punto de referencia del objeto es la punta superior.

#### Peces

Los peces están formados por 5 piramides y 7 esferas. Dos piramides hacen la forma del cuerpo de los peces, otra para la cola y otras dos para las aletas. Como se puede observar en la imagen:

##### Transformadas y Sistema de coordenadas

Las esferas se usan para asimilar a gotas del agua. Todos estos elementos tienen como refencia el cuerpo del pez, incluso las gotas. Y este se relaciona con el planeta. De esta forma, se genera la rotación sobre x y y para el pez, logrando que todos los elementos se muevan de la misma forma.






