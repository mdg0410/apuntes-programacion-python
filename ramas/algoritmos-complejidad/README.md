# Introducción a Algoritmos y Análisis de Complejidad (Big O)

## ¿Qué es un Algoritmo?

Un **algoritmo** es un conjunto de instrucciones bien definidas y ordenadas para resolver un problema o realizar una tarea específica.  Es como una receta de cocina:

*   **Ingredientes:** Datos de entrada (input).
*   **Pasos de la receta:** Instrucciones del algoritmo.
*   **Plato terminado:** Resultado o salida (output).

**Características importantes:**

*   **Finito:** Termina en pasos finitos.
*   **Definido:** Pasos claros y sin ambigüedad.
*   **Entrada (Input):** Cero o más entradas.
*   **Salida (Output):** Al menos una salida.
*   **Efectivo:** Pasos realizables en tiempo finito.

**Ejemplo Sencillo:** Algoritmo para sumar dos números.

## ¿Por qué es Importante el Análisis de Complejidad?

El análisis de complejidad evalúa la **eficiencia** de un algoritmo, midiendo cuánto tiempo y recursos necesita en función del tamaño de la entrada.  Es crucial para:

*   **Velocidad:** Algoritmos eficientes son más rápidos.
*   **Recursos:**  Usan menos recursos computacionales.
*   **Escalabilidad:**  Mantienen buen rendimiento con entradas grandes.

## Notación Big O

La **notación Big O** describe el comportamiento asintótico de la complejidad, indicando cómo crece el tiempo de ejecución o uso de recursos al aumentar el tamaño de la entrada.  Se centra en el **peor caso** e **ignora constantes y términos de menor orden**.

**Tipos Comunes de Complejidad Big O (de mejor a peor):**

*   **O(1) - Constante:**  Tiempo de ejecución constante, independiente del tamaño de la entrada.

    [Image of O(1) Constant Complexity Graph]

    *   **Ejemplo:** Acceder a un elemento de un array por índice.

*   **O(log n) - Logarítmica:**  Tiempo de ejecución crece logarítmicamente.  Divide el problema a la mitad en cada paso.

    [Image of O(log n) Logarithmic Complexity Graph]

    *   **Ejemplo:** Búsqueda binaria en array ordenado.

*   **O(n) - Lineal:** Tiempo de ejecución crece linealmente con el tamaño de la entrada.

    [Image of O(n) Linear Complexity Graph]

    *   **Ejemplo:** Búsqueda lineal en una lista.

*   **O(n log n) - Lineal Logarítmica:**  Un poco peor que lineal, pero eficiente.

    [Image of O(n log n) Linearithmic Complexity Graph]

    *   **Ejemplo:** Ordenación eficiente (Merge Sort, Quick Sort - promedio).

*   **O(n²) - Cuadrática:** Tiempo de ejecución crece cuadráticamente.

    [Image of O(n^2) Quadratic Complexity Graph]

    *   **Ejemplo:**  Bucles anidados que recorren la entrada completa (Bubble Sort).

*   **O(2^n) - Exponencial:**  Tiempo de ejecución crece exponencialmente.  Rápidamente impráctico para entradas grandes.

    [Image of O(2^n) Exponential Complexity Graph]

    *   **Ejemplo:** Fuerza bruta para ciertos problemas.

*   **O(n!) - Factorial:** Complejidad extremadamente mala, crece más rápido que exponencial.

    [Image of O(n!) Factorial Complexity Graph]

    *   **Ejemplo:** Problema del viajante de comercio por fuerza bruta (todas las permutaciones).

**Reglas para Calcular Big O:**

1.  **Constantes se ignoran:** `O(c * f(n)) = O(f(n))`.
2.  **Términos de menor orden se ignoran:** `O(f(n) + g(n)) = O(max(f(n), g(n)))`.
3.  **Regla de la Suma (secuencia):**  `O(f(n) + g(n)) = O(max(f(n), g(n)))`.
4.  **Regla del Producto (anidamiento):** `O(f(n) * g(n))`.

**Ejemplo Práctico: Búsqueda Lineal vs. Binaria**

*   **Búsqueda Lineal:** O(n)
*   **Búsqueda Binaria:** O(log n) (en listas ordenadas)

**Conclusión Big O:**

Herramienta para entender y comparar eficiencia algorítmica.  Fundamental para escribir código escalable y eficiente.

---

**3.  `README.md` (Rama `ramas/estructuras-datos/README.md`)**

