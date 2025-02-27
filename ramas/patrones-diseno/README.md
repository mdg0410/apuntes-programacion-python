# Patrones de Diseño: Factory, Singleton, Observer, Strategy

Soluciones reutilizables a problemas comunes en diseño de software. "Recetas" probadas para software flexible y mantenible.

## Patrón de Diseño Factory (Fábrica)

**Intención:**  Definir interfaz para crear objetos, subclases deciden clase a instanciar. Delegar instanciación a clases hijas.

**Problema Resuelve:**

*   Flexibilidad creación objetos.
*   Desacoplamiento (código cliente - clases concretas).
*   Extensibilidad (añadir nuevas clases sin modificar cliente).

**Estructura (Simplificada):**

*   **Producto:** Interfaz de objetos a crear.
*   **Producto Concreto:** Implementaciones de Producto (clases de objetos).
*   **Creador:** Declara `Factory Method` (devuelve Producto).
*   **Creador Concreto:** Subclases de Creador, redefinen `Factory Method` para Producto Concreto específico.

[Image of Factory Design Pattern Structure]

**Analogía: Fábrica de Coches.** Fábricas especializadas por tipo de coche (Sedan, SUV, Deportivo).

**Ejemplo Conceptual (Pseudo-código):**  Empresa de logística con diferentes tipos de transporte (Camión, Barco, Avión) creados por Factorías concretas.

**Beneficios Patrón Factory:**

*   Desacoplamiento, SRP, OCP, flexibilidad, mantenibilidad, oculta complejidad.

**Cuándo Usar Factory:**

*   Clase no sabe qué clase de objetos crear.
*   Subclases especifican objetos a crear.
*   Centralizar lógica de creación.
*   Crear objetos de varias familias de clases.

## Patrón de Diseño Singleton (Instancia Única)

**Intención:** Asegurar que una clase tenga **una sola instancia**, punto de acceso global.

**Problema Resuelve:**

*   Control de Instancia Única (ej: configuraciones, loggers).
*   Acceso Global Controlado.

**Estructura (Simplificada):**

*   **Singleton:** Clase que garantiza instancia única.
    *   Atributo estático privado (instancia única).
    *   Constructor privado (evitar instanciación directa).
    *   Método estático público `getInstance()` (devuelve instancia única, crea si no existe).

[Image of Singleton Design Pattern Structure]

**Analogía: El Presidente de un País.** Instancia única con acceso global.

**Ejemplo Conceptual (Pseudo-código):** Clase `SingletonConfiguracion` con método `obtenerInstancia()`.

**Beneficios Patrón Singleton:**

*   Control instancia única, acceso global, ahorro de recursos, espacio de nombres global encapsulado.

**Cuándo Usar Singleton:**

*   Una instancia única necesaria.
*   Acceso global bien conocido.
*   Instancia única extensible por subclases.

**Consideraciones/Desventajas Singleton:**

*   Violación SRP (a veces), dificultad pruebas unitarias, acoplamiento global (potencial), concurrencia (cuidado).  Usar con moderación.

## Patrón de Diseño Observer (Observador)

**Intención:** Definir dependencia uno-a-muchos. Sujeto cambia estado, Observadores notificados y actualizados automáticamente.

**Problema Resuelve:**

*   Dependencia Uno-a-Muchos.
*   Acoplamiento Débil (Sujeto-Observadores).
*   Notificación Automática.

**Estructura (Simplificada):**

*   **Sujeto:**  Mantiene estado, notifica a Observadores. Lista de Observadores, métodos para adjuntar/separar, método para notificar.
*   **Observador:** Interfaz con método `actualizar()`.
*   **Observador Concreto:** Implementaciones de Observador, reaccionan a notificaciones.

[Image of Observer Design Pattern Structure]

**Analogía: Suscripción a Revista.** Revista (Sujeto) notifica a Suscriptores (Observadores) nuevas publicaciones.

**Ejemplo Conceptual (Pseudo-código):**  Sujeto `SujetoConcreto`, Observadores `ObservadorGrafico`, `ObservadorLog`.

**Beneficios Patrón Observer:**

*   Acoplamiento débil, OCP, soporte transmisión info, base para patrones Pub/Sub.

**Cuándo Usar Observer:**

*   Cambio en objeto requiere cambiar otros objetos (desconocidos a priori).
*   Objeto notifica a otros sin suposiciones sobre quiénes son.
*   Dependencias sin acoplamiento fuerte.

## Patrón de Diseño Strategy (Estrategia)

**Intención:** Definir familia de algoritmos, encapsular cada uno, hacerlos intercambiables. Algoritmo varía independientemente de clientes.

**Problema Resuelve:**

*   Variedad de Algoritmos (misma tarea).
*   Selección Dinámica de Algoritmos.
*   Eliminar Condicionales Largos (selección algoritmo).
*   Reutilización/Composición de Algoritmos.

**Estructura (Simplificada):**

*   **Estrategia:** Interfaz para algoritmos concretos (método común).
*   **Estrategia Concreta:** Implementaciones de Estrategia, encapsulan algoritmo específico.
*   **Contexto:**  Clase que usa Estrategia. Delega ejecución algoritmo a Estrategia. Permite cambiar Estrategia dinámicamente.

[Image of Strategy Design Pattern Structure]

**Analogía: Estrategias de Ordenación.** Diferentes algoritmos (QuickSort, MergeSort, etc.) intercambiables en un `OrdenadorDeListas`.

**Ejemplo Conceptual (Pseudo-código):**  `CarritoDeCompras` con diferentes `EstrategiaPago` (TarjetaCredito, PayPal, Transferencia).

**Beneficios Patrón Strategy:**

*   Algoritmos intercambiables, OCP, elimina condicionales largas, reutilización algoritmos, mejor organización.

**Cuándo Usar Strategy:**

*   Diferentes algoritmos para misma tarea, intercambiables dinámicamente.
*   Clases relacionadas difieren solo en comportamiento (algoritmo).
*   Evitar condicionales largos para seleccionar algoritmos.
*   Encapsular algoritmos, independientes de Contextos.

---

**6.  `README.md` (Rama `main/ecommerce_simplificado/README.md`)**
