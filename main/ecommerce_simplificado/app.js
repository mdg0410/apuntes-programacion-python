class Producto {
    constructor(idProducto, nombre, precio, descripcion, categoria) {
        this.idProducto = idProducto;
        this.nombre = nombre;
        this.precio = precio;
        this.descripcion = descripcion;
        this.categoria = categoria;
    }
}

class GestionProductos {
    constructor() {
        this.productos = new Map();
    }

    agregarProducto(producto) {
        this.productos.set(producto.idProducto, producto);
    }

    verDetallesProducto(idProducto) {
        const producto = this.productos.get(idProducto);
        if (producto) {
            console.log(`ID: ${producto.idProducto}, Nombre: ${producto.nombre}, Precio: ${producto.precio}, Descripción: ${producto.descripcion}, Categoría: ${producto.categoria}`);
        } else {
            console.log("Producto no encontrado.");
        }
    }

    listarProductosPorCategoria(categoria) {
        for (const producto of this.productos.values()) {
            if (producto.categoria === categoria) {
                console.log(`ID: ${producto.idProducto}, Nombre: ${producto.nombre}, Precio: ${producto.precio}`);
            }
        }
    }
}

class CarritoDeCompras {
    constructor() {
        this.items = new Map();
    }

    agregarProducto(producto, cantidad) {
        if (this.items.has(producto.idProducto)) {
            this.items.set(producto.idProducto, this.items.get(producto.idProducto) + cantidad);
        } else {
            this.items.set(producto.idProducto, cantidad);
        }
    }

    eliminarProducto(producto) {
        this.items.delete(producto.idProducto);
    }

    verCarrito() {
        for (const [idProducto, cantidad] of this.items.entries()) {
            console.log(`Producto ID: ${idProducto}, Cantidad: ${cantidad}`);
        }
    }

    calcularTotal(productos) {
        let total = 0;
        for (const [idProducto, cantidad] of this.items.entries()) {
            total += cantidad * productos.get(idProducto).precio;
        }
        return total;
    }
}

class Orden {
    constructor(carrito, productos) {
        this.carrito = carrito;
        this.total = carrito.calcularTotal(productos);
    }

    generarConfirmacion() {
        console.log("Orden confirmada. Detalles de la orden:");
        this.carrito.verCarrito();
        console.log(`Total: ${this.total}`);
    }
}

class EstrategiaPago {
    realizarPago(cantidad) {}
}

class PagoTarjetaCredito extends EstrategiaPago {
    realizarPago(cantidad) {
        console.log(`Pago de ${cantidad} realizado con tarjeta de crédito.`);
    }
}

class PagoPayPal extends EstrategiaPago {
    realizarPago(cantidad) {
        console.log(`Pago de ${cantidad} realizado con PayPal.`);
    }
}

class PagoTransferenciaBancaria extends EstrategiaPago {
    realizarPago(cantidad) {
        console.log(`Pago de ${cantidad} realizado con transferencia bancaria.`);
    }
}

// Ejemplo de uso
const gestionProductos = new GestionProductos();

// Crear algunos productos
const producto1 = new Producto(1, "Laptop", 1500, "Laptop de alta gama", "Electrónica");
const producto2 = new Producto(2, "Libro de Python", 40, "Libro para aprender Python", "Libros");
const producto3 = new Producto(3, "Camiseta", 20, "Camiseta de algodón", "Ropa");

// Agregar productos al sistema
gestionProductos.agregarProducto(producto1);
gestionProductos.agregarProducto(producto2);
gestionProductos.agregarProducto(producto3);

// Ver detalles de un producto específico
gestionProductos.verDetallesProducto(1);

// Listar productos por categoría
console.log("Productos en la categoría 'Libros':");
gestionProductos.listarProductosPorCategoria("Libros");
