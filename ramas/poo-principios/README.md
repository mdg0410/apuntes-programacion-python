# Programación Orientada a Objetos (POO) y Principios SOLID, DRY, KISS

## Programación Orientada a Objetos (POO)

Paradigma de programación centrado en **"objetos"** que combinan datos y código.

### Clases y Objetos

*   **Clase:** Plantilla, plano, molde para crear objetos. Define **estructura** (atributos) y **comportamiento** (métodos). Analogía: Plano de casa.
    *   **Atributos (Propiedades):** Datos que caracterizan objetos. (Ej: `color`, `marca`).
    *   **Métodos (Operaciones):** Acciones que los objetos pueden realizar. (Ej: `acelerar()`, `frenar()`).
*   **Objeto:** Instancia de una clase. Entidad concreta creada a partir del plano. Analogía: Casa real construida con el plano.
    *   **Estado:** Valor actual de sus atributos. (Ej: `color = "rojo"`, `velocidad_actual = 0`).
    *   **Comportamiento:** Definido por los métodos de la clase, operando sobre el estado del objeto.

[Image of Class and Objects Analogy: Car Blueprint and Cars]

**Ejemplo Conceptual (Pseudo-código):** Definición de clase `Coche` y creación de objetos `coche1`, `coche2`.

**Beneficios de Clases y Objetos:**

*   Organización, modularidad, reutilización, abstracción.

### Herencia

Mecanismo para crear **nuevas clases (subclases)** basadas en **clases existentes (superclases)**. Subclase hereda y puede extender/modificar. Analogía: Herencia familiar.

[Image of Inheritance Analogy: Family Tree]

*   **Clase Padre: Vehículo:** Características generales.
*   **Clase Hija: Coche:**  Hereda de Vehículo, especializa (puertas, asientos).
*   **Clase Nieta: CocheDeportivo:** Hereda de Coche, especializa aún más (alerón, turbo).

**Ejemplo Conceptual (Pseudo-código):**  Jerarquía de clases `Vehículo`, `Coche`, `CocheDeportivo`.

**Beneficios de la Herencia:**

*   Reutilización de código, extensibilidad, jerarquías, mantenibilidad.

### Polimorfismo

Capacidad de un objeto de **tomar muchas formas** o de una acción de comportarse diferente según contexto.

1.  **Sobrecarga (Overloading):** Múltiples métodos con **mismo nombre**, pero **diferentes parámetros** (tipos o número).  Ej: Método `sumar()` para enteros, decimales, cadenas.

    **Analogía: Sobrecarga de Método "Sumar".**

    **Ejemplo Conceptual (Pseudo-código - Sobrecarga):** Clase `Calculadora` con métodos `sumar()` sobrecargados.

2.  **Redefinición/Sobreescritura (Overriding):**  En herencia. Subclase **redefine** método de superclase para implementación específica. Ej: Método `hacer_sonido()` en clases `Animal`, `Perro`, `Gato`.

    **Analogía: Redefinición de Método "Moverse".**

    **Ejemplo Conceptual (Pseudo-código - Redefinición):** Clases `Animal`, `Perro`, `Gato` con método `hacer_sonido()` redefinido.

**Beneficios del Polimorfismo:**

*   Flexibilidad, extensibilidad, reutilización (con interfaces), simplificación.

### Encapsulamiento

Ocultar detalles internos de objeto, exponer interfaz bien definida. "Encapsular" datos (atributos) y métodos. Controlar acceso a datos. Analogía: Máquina Expendedora.

[Image of Encapsulation Analogy: Vending Machine]

*   **Interfaz Pública:** Botones, ranura de monedas (interacción usuario).
*   **Implementación Interna:** Mecanismos internos (ocultos, protegidos).

**Niveles de Acceso (comunes):**

*   **Público (public):** Accesible desde cualquier parte. Interfaz pública.
*   **Privado (private):** Accesible solo dentro de la clase. Implementación interna.
*   **Protegido (protected):** Accesible en la clase y subclases. Herencia.

**Ejemplo Conceptual (Pseudo-código - Encapsulamiento):** Clase `CuentaBancaria` con atributo privado `saldo_privado` y métodos públicos `depositar()`, `retirar()`, `obtener_saldo()`.

**Beneficios del Encapsulamiento:**

*   Ocultamiento de implementación, control de acceso, modularidad, mantenibilidad.

## Principios SOLID, DRY, KISS

Principios de diseño para código de alta calidad, mantenible y escalable (POO).

### Principios SOLID

*   **S - Single Responsibility Principle (SRP):**  Una clase, una razón para cambiar. Una única responsabilidad bien definida.

    **Analogía: Cuchillo Suizo vs. Herramientas Especializadas.**

    **Ejemplo (Violación SRP):** Clase `GestorDeUsuarios` (lógica de negocio + persistencia).
    **Solución (SRP):**  `ServicioDeUsuarios`, `RepositorioDeUsuarios`.

*   **O - Open/Closed Principle (OCP):** Abierto a extensión, cerrado a modificación.  Extender sin modificar código existente (abstracción, polimorfismo).

    **Analogía: Enchufe Eléctrico (extensible, estable).**

    **Ejemplo (Violación OCP):** Clase `ProcesadorDePagos` (soporte para varios métodos con `if/else`).
    **Solución (OCP):** Interfaz `MetodoDePago`, clases `TarjetaCreditoPago`, `PayPalPago`.

*   **L - Liskov Substitution Principle (LSP):** Subclases sustituibles por superclases sin romper el programa. Subclase mantiene "contrato" de superclase.

    **Analogía (Violación LSP - Cuadrado y Rectángulo):** Herencia incorrecta puede romper comportamiento esperado.

    **Solución (LSP):** Reconsiderar herencia.  Asegurar que subclase "es un tipo de" superclase en comportamiento.

*   **I - Interface Segregation Principle (ISP):** Muchas interfaces específicas, mejor que una general. Clases no forzadas a implementar métodos que no usan.

    **Analogía: Puerta con demasiados botones vs. Puertas específicas para usuarios.**

    **Ejemplo (Violación ISP):** Interfaz `Trabajador` (métodos para todos los "trabajadores", incluso robots que no comen).
    **Solución (ISP):** Interfaces más pequeñas: `Trabajador`, `TrabajadorComedor`, etc.

*   **D - Dependency Inversion Principle (DIP):**  Depender de abstracciones, no de concreciones. Alto nivel y bajo nivel dependen de abstracciones. Detalles dependen de abstracciones. Desacoplamiento.

    **Analogía: Lámpara y Bombilla (dependen de estándar, no uno del otro).**

    **Ejemplo (Violación DIP):** `ServicioDeNotificaciones` depende directamente de `ServicioDeEmail`.
    **Solución (DIP):** Interfaz `ServicioDeMensajeria`, clases `ServicioDeEmail`, `ServicioDeSMS`.

### Principio DRY (Don't Repeat Yourself - No te Repitas)

"Cada pieza de conocimiento, una representación única." Evitar duplicación de código.  Abstraer lógica repetida en un lugar único (función, método, clase).

**Beneficios:** Mantenibilidad, legibilidad, reducción de errores.

**Ejemplo (Violación DRY):** Funciones `validar_nombre_usuario_formulario1`, `validar_nombre_usuario_formulario2` (código de validación duplicado).
**Solución (DRY):** Función única `validar_nombre_usuario`, reutilizada.

### Principio KISS (Keep It Simple, Stupid - Mantenlo Simple, Estúpido)

"Simplicidad, objetivo clave en diseño."  Evitar complejidad innecesaria.  Soluciones sencillas, fáciles de entender.

**Beneficios:** Legibilidad, mantenibilidad, menos errores, desarrollo más rápido.

**Ejemplo (Violación KISS - Complejidad Innecesaria):** Función `encontrar_maximo_complejo` (ordena lista innecesariamente).
**Solución (KISS):** Función `encontrar_maximo_simple` (iteración directa).

---

**5.  `README.md` (Rama `ramas/patrones-diseno/README.md`)**


```markdown
# Proyecto: Sistema de E-commerce Simplificado (Backend Lógico - Python)

## Descripción General

Este proyecto implementa un sistema backend lógico simplificado para un e-commerce en Python.  Se centra en la lógica de negocio principal (gestión de productos, carrito, órdenes, pagos) utilizando principios de POO y patrones de diseño aprendidos.  No incluye interfaz gráfica de usuario ni persistencia de datos en base de datos real (los datos se gestionan en memoria).

**Funcionalidades Implementadas:**

1.  **Gestión de Productos:**
    *   Clase `Producto` (atributos: `id_producto`, `nombre`, `precio`, `descripción`, `categoría`).
    *   Funcionalidades para:
        *   Agregar productos (simulación de almacenamiento en memoria).
        *   Ver detalles de producto.
        *   Listar productos por categoría.

2.  **Carrito de Compras:**
    *   Clase `CarritoDeCompras`.
    *   Funcionalidades para:
        *   Agregar productos al carrito (con cantidad).
        *   Eliminar productos del carrito.
        *   Ver productos en el carrito (con cantidades y precios).
        *   Calcular precio total del carrito.

3.  **Gestión de Órdenes:**
    *   Clase `Orden`.
    *   Funcionalidades para:
        *   Crear orden desde carrito.
        *   Calcular total de orden.
        *   Procesar pago (con Strategy Pattern).
        *   Generar confirmación de orden (consola).

4.  **Métodos de Pago (Patrón Strategy):**
    *   Implementación del Patrón Strategy para métodos de pago.
    *   Estrategias concretas:
        *   `PagoTarjetaCredito`
        *   `PagoPayPal`
        *   `PagoTransferenciaBancaria`
    *   Simulación de pago (imprimir mensaje).

5.  **(Opcional) Fábrica de Productos (Patrón Factory):**
    *   [No implementado en esta versión inicial]  Considerar en futuras iteraciones.

6.  **(Opcional) Gestión de Configuración (Patrón Singleton):**
    *   [No implementado en esta versión inicial]  Considerar si es necesario en futuras expansiones.

**Estructura del Código:**

*   `codigo/`:  Carpeta que contiene el código fuente en Python.
    *   `productos.py`: Definición de la clase `Producto`.
    *   `carrito_compras.py`: Definición de la clase `CarritoDeCompras`.
    *   `ordenes.py`: Definición de la clase `Orden`.
    *   `estrategias_pago.py`: Definición de la interfaz `EstrategiaPago` y clases concretas de pago.
    *   `main.py`:  Script principal con ejemplo de uso y simulación del sistema.

**Cómo Ejecutar el Proyecto:**

1.  Asegúrate de tener Python instalado.
2.  Navega al directorio `main/ecommerce_simplificado/codigo/`.
3.  Ejecuta el script principal: `python main.py`

**Principios POO y Patrones de Diseño Aplicados:**

*   **Programación Orientada a Objetos:**  Uso de clases y objetos para modelar las entidades del e-commerce (Productos, Carrito, Órdenes, etc.).
*   **Encapsulamiento:**  Clases encapsulan datos y comportamiento.
*   **Polimorfismo:**  Patrón Strategy para métodos de pago.
*   **Patrón Strategy:**  Implementación de diferentes estrategias de pago (Tarjeta, PayPal, Transferencia) intercambiables en tiempo de ejecución.
*   **Principios SOLID:**  Se ha intentado aplicar principios SOLID, especialmente el Principio de Responsabilidad Única (cada clase con una responsabilidad clara) y el Principio Abierto/Cerrado (extensibilidad con el patrón Strategy).
*   **DRY, KISS:**  Se ha priorizado la simplicidad y se ha evitado la duplicación de código.

**Mejoras Futuras:**

*   Implementar el Patrón Factory para la creación de productos.
*   Añadir persistencia de datos (usar una base de datos).
*   Implementar más funcionalidades del e-commerce (gestión de usuarios, inventario, etc.).
*   Desarrollar una interfaz de usuario (frontend).
*   Añadir pruebas unitarias.

**Conclusiones:**

Este proyecto proporciona una base sólida para comprender e implementar los conceptos de POO y patrones de diseño en un contexto práctico.  Sirve como punto de partida para construir sistemas más complejos y robustos.

---

¡Espero que estos textos te sean de gran utilidad para documentar tu repositorio en GitHub!  Recuerda que puedes personalizarlos y adaptarlos a tu gusto.  ¡Mucho éxito con tu repositorio y con tu aprendizaje! 😊