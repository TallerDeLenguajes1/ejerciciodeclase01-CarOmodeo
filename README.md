# ejerciciodeclase01-CarOmodeo
ejerciciodeclase01-CarOmodeo created by GitHub Classroom
## Problema 1
**Excepción producida:** IndexOutOfRangeException

Se produce cuando se intenta acceder a un elemento de un arreglo o colección que esta fuera del tamaño de los mismos.

**Solución propuesta:** colocar una estructura try-catch, que intercepte la excepción para que no se rompa el programa. El catch muestra un cartel de error.


## Problema 2
**Excepción producida:** OverflowException

Se produce cuando una operación aritmética, de casteo o de conversión producen un desbordamiento dentro de sus respectivos contextos.

**Solución propuesta:** colocar una estructura try-catch, que intercepte dicho evento y devuelva un mensaje con la descripción del error.


## Problema 3
**Excepción producida:** NullReferenceException

Se produce cuando se intenta acceder a un objeto de referencia NULL.

**Solución propuesta:** se coloco una estructura try-catch para interceptar la excepción y mostrar un mensaje anunciando el error producido. Ademas, se tuvo que modificar la configuración del Visual Studio, ya que a pesar la implementación del try-catch, el programa se paraba igual.


## Problema 4
**Excepción producida:** FormatException

Se produce cuando el formato del argumento no es valido o cuando la composición del string no es el correcto.

**Solución propuesta:** se coloco un try-catch que al interceptar la excepción muestra un mensaje de error, evitando que se rompa el programa.


## AdivinarNumero
**Excepción producida:** FormatException y OverflowException

Ambas excepciones fueron definidas en el problema 4 y 2 respectivamente.

**Solución propuesta:** Se coloco una estructura try-catch con 2 catch, uno para cada excepción. En ambos casos muestra el mismo mensaje de error y el código se sigue ejecutando. Se coloco una penalización, ya que esos intentos se los tienen en cuenta.
