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