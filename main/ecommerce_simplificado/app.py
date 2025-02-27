class Producto:
    def __init__(self, id_producto, nombre, precio, descripcion, categoria):
        self.id_producto = id_producto
        self.nombre = nombre
        self.precio = precio
        self.descripcion = descripcion
        self.categoria = categoria

class GestionProductos:
    def __init__(self):
        self.productos = {}

    def agregar_producto(self, producto):
        self.productos[producto.id_producto] = producto

    def ver_detalles_producto(self, id_producto):
        producto = self.productos.get(id_producto)
        if producto:
            print(f"ID: {producto.id_producto}, Nombre: {producto.nombre}, Precio: {producto.precio}, Descripción: {producto.descripcion}, Categoría: {producto.categoria}")
        else:
            print("Producto no encontrado.")

    def listar_productos_por_categoria(self, categoria):
        for producto in self.productos.values():
            if producto.categoria == categoria:
                print(f"ID: {producto.id_producto}, Nombre: {producto.nombre}, Precio: {producto.precio}")

class CarritoDeCompras:
    def __init__(self):
        self.items = {}

    def agregar_producto(self, producto, cantidad):
        if producto.id_producto in self.items:
            self.items[producto.id_producto] += cantidad
        else:
            self.items[producto.id_producto] = cantidad

    def eliminar_producto(self, producto):
        if producto.id_producto in self.items:
            del self.items[producto.id_producto]

    def ver_carrito(self):
        for id_producto, cantidad in self.items.items():
            print(f"Producto ID: {id_producto}, Cantidad: {cantidad}")

    def calcular_total(self):
        total = 0
        for id_producto, cantidad in self.items.items():
            total += cantidad * id_producto.precio
        return total

class Orden:
    def __init__(self, carrito):
        self.carrito = carrito
        self.total = carrito.calcular_total()

    def generar_confirmacion(self):
        print("Orden confirmada. Detalles de la orden:")
        self.carrito.ver_carrito()
        print(f"Total: {self.total}")

class EstrategiaPago:
    def realizar_pago(self, cantidad):
        pass

class PagoTarjetaCredito(EstrategiaPago):
    def realizar_pago(self, cantidad):
        print(f"Pago de {cantidad} realizado con tarjeta de crédito.")

class PagoPayPal(EstrategiaPago):
    def realizar_pago(self, cantidad):
        print(f"Pago de {cantidad} realizado con PayPal.")

class PagoTransferenciaBancaria(EstrategiaPago):
    def realizar_pago(self, cantidad):
        print(f"Pago de {cantidad} realizado con transferencia bancaria.")

if __name__ == "__main__":
    gestion_productos = GestionProductos()

    # Crear algunos productos
    producto1 = Producto(1, "Laptop", 1500, "Laptop de alta gama", "Electrónica")
    producto2 = Producto(2, "Libro de Python", 40, "Libro para aprender Python", "Libros")
    producto3 = Producto(3, "Camiseta", 20, "Camiseta de algodón", "Ropa")

    # Agregar productos al sistema
    gestion_productos.agregar_producto(producto1)
    gestion_productos.agregar_producto(producto2)
    gestion_productos.agregar_producto(producto3)

    # Ver detalles de un producto específico
    gestion_productos.ver_detalles_producto(1)

    # Listar productos por categoría
    print("Productos en la categoría 'Libros':")
    gestion_productos.listar_productos_por_categoria("Libros")
