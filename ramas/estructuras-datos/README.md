# Estructuras de Datos (Listas, Pilas, Colas)

## ¿Qué son las Estructuras de Datos?

Una **estructura de datos** es una forma de organizar y almacenar datos en una computadora para un acceso y uso eficiente. La elección correcta impacta la eficiencia del algoritmo.

Analogía: Organización de libros en una biblioteca (alfabético, género, aleatorio).

**Tipos Principales (Estructuras Lineales):** Listas, Pilas, Colas.

## Listas (Arrays Dinámicos)

**Características:**

*   **Colección ordenada:** Elementos en orden específico.
*   **Indexadas:** Acceso directo por índice (posición).
*   **Mutables:** Modificables (agregar, eliminar, modificar).
*   **Tamaño dinámico:** Crecen/decrecen (arreglos dinámicos).

**Operaciones Comunes (Complejidad Big O):**

*   **Acceso por índice:** `lista[indice]` - O(1)
*   **Insertar al final (append):** `lista.append(elemento)` - O(1) (promedio)
*   **Insertar en posición:** `lista.insert(indice, elemento)` - O(n) (promedio)
*   **Eliminar al final (pop):** `lista.pop()` - O(1) (promedio)
*   **Eliminar por índice:** `lista.pop(indice)` - O(n) (promedio)
*   **Eliminar por valor:** `lista.remove(valor)` - O(n) (promedio)
*   **Buscar (lineal):** `valor in lista` - O(n) (promedio)
*   **Longitud (tamaño):** `len(lista)` - O(1)

**Ejemplo Python:** Código de ejemplo mostrando operaciones en listas.

**Usos Comunes:**

*   Colecciones ordenadas.
*   Implementar otras estructuras (pilas, colas).
*   Representar secuencias de datos.

## Pilas (Stacks)

**Principio LIFO (Last In First Out):** Último en entrar, primero en salir.  Analogía: Pila de platos.

[Image of Stack of Plates Analogy]

**Características:**

*   **LIFO:** Acceso solo a la cima (top).
*   **Operaciones Principales:**
    *   **Push (Apilar):** Agregar a la cima.
    *   **Pop (Desapilar):** Eliminar y devolver de la cima.
    *   **Peek (Cima/Top):** Ver cima sin eliminar.
    *   **IsEmpty:** Verificar si vacía.

**Operaciones en Pilas (Analogía Platos):**

*   **Push:** Poner plato encima.
*   **Pop:** Quitar plato de arriba.
*   **Peek:** Ver plato de arriba.
*   **IsEmpty:** ¿Hay platos?

**Ejemplo Python (simulación con lista):**  Código de ejemplo de operaciones de pila.

**Usos Comunes:**

*   Pila de llamadas a funciones (Call Stack).
*   Undo/Redo (Deshacer/Rehacer).
*   Evaluación de expresiones matemáticas.
*   Backtracking (Retroceso) en algoritmos.

## Colas (Queues)

**Principio FIFO (First In First Out):** Primero en entrar, primero en salir. Analogía: Cola de supermercado.

[Image of Supermarket Queue Analogy]

**Características:**

*   **FIFO:**  Elementos eliminados en orden de adición.
*   **Operaciones Principales:**
    *   **Enqueue (Encolar):** Agregar al final (rear).
    *   **Dequeue (Desencolar):** Eliminar y devolver del frente (front).
    *   **Peek/Front:** Ver el frente sin eliminar.
    *   **IsEmpty:** Verificar si vacía.

**Operaciones en Colas (Analogía Supermercado):**

*   **Enqueue:** Formarse en la cola.
*   **Dequeue:** Ser atendido (sale de la cola).
*   **Peek/Front:** Ver quién está al frente.
*   **IsEmpty:** ¿Hay gente en la cola?

**Ejemplo Python (simulación con lista - no óptimo para colas grandes):** Código de ejemplo de operaciones de cola.

**Usos Comunes:**

*   Gestión de colas de tareas (Task Queues).
*   Simulaciones (colas de espera).
*   Breadth-First Search (Búsqueda en Anchura).
*   Comunicación entre procesos (FIFO).

**Nota de eficiencia de colas en Python:**  `collections.deque` para colas eficientes.

---

**4.  `README.md` (Rama `ramas/poo-principios/README.md`)**


