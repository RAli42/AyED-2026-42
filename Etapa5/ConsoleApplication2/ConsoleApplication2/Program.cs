
using System;
public class Producto
{
    private int id;
    private string nombre;
    private string categoria;
    private double precioCompra;
    private int stock;

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public string Categoria
    {
        get { return categoria; }
        set { categoria = value; }
    }

    public double PrecioCompra
    {
        get { return precioCompra; }
        set { precioCompra = value; }
    }

    public int Stock
    {
        get { return stock; }
        set { stock = value; }
    }

    public Producto(int nuevoId, string nuevoNombre,
        string nuevaCategoria, double nuevoPrecio, int nuevoStock)
    {
        id = nuevoId;
        nombre = nuevoNombre;
        categoria = nuevaCategoria;
        precioCompra = nuevoPrecio;
        stock = nuevoStock;
    }

    public double CalcularPrecioVenta(double porcentajeGanancia)
    {
        return precioCompra + (precioCompra * porcentajeGanancia / 100);
    }

    public void MostrarInfo()
    {
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Categoria: " + categoria);
        Console.WriteLine("Precio de compra: $" + precioCompra.ToString("N2"));
        Console.WriteLine("Stock: " + stock);
    }
}

// ===============================
// CLASE SUCURSAL
// ===============================

public class Sucursal
{
    private int id;
    private string nombre;
    private string ciudad;

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public string Ciudad
    {
        get { return ciudad; }
        set { ciudad = value; }
    }

    public Sucursal(int nuevoId, string nuevoNombre, string nuevaCiudad)
    {
        id = nuevoId;
        nombre = nuevoNombre;
        ciudad = nuevaCiudad;
    }

    public void MostrarDetalle()
    {
        Console.WriteLine("ID de sucursal: " + id);
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Ciudad: " + ciudad);
    }
}

// ===============================
// CLASE VENTA
// ===============================

public class Venta
{
    private int idVenta;
    private int idProducto;
    private int cantidad;
    private double montoTotal;

    public int IdVenta
    {
        get { return idVenta; }
        set { idVenta = value; }
    }

    public int IdProducto
    {
        get { return idProducto; }
        set { idProducto = value; }
    }

    public int Cantidad
    {
        get { return cantidad; }
        set { cantidad = value; }
    }

    public double MontoTotal
    {
        get { return montoTotal; }
        set { montoTotal = value; }
    }

    public Venta(int nuevoIdVenta, int nuevoIdProducto,
        int nuevaCantidad, double nuevoMonto)
    {
        idVenta = nuevoIdVenta;
        idProducto = nuevoIdProducto;
        cantidad = nuevaCantidad;
        montoTotal = nuevoMonto;
    }

    public double AplicarDescuento(double porcentaje)
    {
        if (cantidad > 5)
        {
            montoTotal = montoTotal - (montoTotal * porcentaje / 100);
        }

        return montoTotal;
    }
}

// ===============================
// GESTOR DE INVENTARIO
// ===============================

public class GestorInventario
{
    private Producto[] productos;
    private int contadorProductos;

    public GestorInventario()
    {
        productos = new Producto[5];
        contadorProductos = 0;
    }

    public void CargarProductosIniciales()
    {
        productos[0] = new Producto(1, "Teclado mecanico",
            "Computacion", 45000, 10);

        productos[1] = new Producto(2, "Mouse gamer",
            "Computacion", 25000, 15);

        productos[2] = new Producto(3, "Auriculares",
            "Audio", 38000, 8);

        productos[3] = new Producto(4, "Celular",
            "Celulares", 350000, 6);

        productos[4] = new Producto(5, "Monitor",
            "Computacion", 220000, 4);

        contadorProductos = 5;
    }

    public void MostrarCatalogo()
    {
        Console.WriteLine("\n===== CATALOGO DE PRODUCTOS =====");

        for (int i = 0; i < contadorProductos; i++)
        {
            if (productos[i] != null)
            {
                productos[i].MostrarInfo();

                Console.WriteLine("Precio de venta: $" +
                    productos[i].CalcularPrecioVenta(30).ToString("N2"));

                Console.WriteLine("-----------------------------");
            }
        }
    }

    // NUEVO: MOSTRAR PRODUCTOS CON STOCK

    public void MostrarProductosConStock()
    {
        Console.WriteLine("\n===== PRODUCTOS DISPONIBLES =====");

        for (int i = 0; i < contadorProductos; i++)
        {
            if (productos[i] != null && productos[i].Stock > 0)
            {
                Console.WriteLine("ID: " + productos[i].Id);
                Console.WriteLine("Producto: " + productos[i].Nombre);
                Console.WriteLine("Stock disponible: " + productos[i].Stock);
                Console.WriteLine("-----------------------------");
            }
        }
    }

    public Producto BuscarProductoPorId(int id)
    {
        for (int i = 0; i < contadorProductos; i++)
        {
            if (productos[i] != null && productos[i].Id == id)
            {
                return productos[i];
            }
        }

        return null;
    }

    public void ActualizarStock(int idProducto, int cantidadVendida)
    {
        Producto producto = BuscarProductoPorId(idProducto);

        if (producto != null && cantidadVendida > 0 &&
            producto.Stock >= cantidadVendida)
        {
            producto.Stock = producto.Stock - cantidadVendida;
        }
    }
}

// ===============================
// CLASE PEDIDO
// ===============================

public class Pedido
{
    private int idPedido;
    private int idProducto;
    private string nombreProducto;
    private int cantidad;
    private string destino;
    private double costoEnvio;
    private string estado;

    public int IdPedido
    {
        get { return idPedido; }
        set { idPedido = value; }
    }

    public int IdProducto
    {
        get { return idProducto; }
        set { idProducto = value; }
    }

    public string NombreProducto
    {
        get { return nombreProducto; }
        set { nombreProducto = value; }
    }

    public int Cantidad
    {
        get { return cantidad; }
        set { cantidad = value; }
    }

    public string Destino
    {
        get { return destino; }
        set { destino = value; }
    }

    public double CostoEnvio
    {
        get { return costoEnvio; }
        set { costoEnvio = value; }
    }

    public string Estado
    {
        get { return estado; }
        set { estado = value; }
    }

    public Pedido(int nuevoId, int nuevoIdProducto,
        string nuevoNombre, int nuevaCantidad,
        string nuevoDestino, double nuevoCostoEnvio)
    {
        idPedido = nuevoId;
        idProducto = nuevoIdProducto;
        nombreProducto = nuevoNombre;
        cantidad = nuevaCantidad;
        destino = nuevoDestino;
        costoEnvio = nuevoCostoEnvio;
        estado = "Pendiente";
    }

    public void MostrarPedido()
    {
        Console.WriteLine("Numero de pedido: " + idPedido);
        Console.WriteLine("Producto: " + nombreProducto);
        Console.WriteLine("Cantidad: " + cantidad);
        Console.WriteLine("Destino: " + destino);
        Console.WriteLine("Costo de envio: $" + costoEnvio.ToString("N2"));
        Console.WriteLine("Estado: " + estado);
    }
}

// ===============================
// GESTOR DE PEDIDOS
// ===============================

public class GestorPedidos
{
    private Pedido[] pedidos;
    private int contadorPedidos;

    public GestorPedidos()
    {
        pedidos = new Pedido[50];
        contadorPedidos = 0;
    }

    public int HayEspacio()
    {
        if (contadorPedidos < pedidos.Length)
        {
            return 1;
        }

        return 0;
    }

    public void AgregarPedido(Pedido pedido)
    {
        if (contadorPedidos < pedidos.Length)
        {
            pedidos[contadorPedidos] = pedido;
            contadorPedidos++;
        }
    }

    public int MostrarPedidosPendientes()
    {
        int cantidadPendientes = 0;

        Console.WriteLine("\n===== PEDIDOS PENDIENTES =====");

        for (int i = 0; i < contadorPedidos; i++)
        {
            if (pedidos[i].Estado == "Pendiente")
            {
                pedidos[i].MostrarPedido();

                Console.WriteLine("-----------------------------");

                cantidadPendientes++;
            }
        }

        return cantidadPendientes;
    }

    public int RegistrarEntrega(int idPedido)
    {
        for (int i = 0; i < contadorPedidos; i++)
        {
            if (pedidos[i].IdPedido == idPedido)
            {
                if (pedidos[i].Estado == "Pendiente")
                {
                    pedidos[i].Estado = "Entregado";
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }

        return 0;
    }
}

// ===============================
// REPORTE MATRIZ
// ===============================

public class ReporteMatriz
{
    private double[,] matrizVentas;

    private string[] dias =
    {
        "Lunes", "Martes", "Miercoles", "Jueves", "Viernes"
    };

    public ReporteMatriz()
    {
        matrizVentas = new double[3, 5];
    }

    public void CargarVentasSimuladas()
    {
        double[,] datos =
        {
            { 150000, 180000, 120000, 200000, 170000 },
            { 210000, 160000, 250000, 190000, 230000 },
            { 100000, 140000, 180000, 150000, 220000 }
        };

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                matrizVentas[i, j] = datos[i, j];
            }
        }
    }

    public void AgregarVenta(int indiceSucursal, int indiceDia, double monto)
    {
        if (indiceSucursal >= 0 && indiceSucursal < 3 &&
            indiceDia >= 0 && indiceDia < 5 && monto > 0)
        {
            matrizVentas[indiceSucursal, indiceDia] += monto;
        }
    }

    public void MostrarMatrizVentas()
    {
        Console.WriteLine("\n===== MATRIZ DE VENTAS =====");

        Console.Write("{0,-15}", "Sucursal");

        foreach (string dia in dias)
        {
            Console.Write("{0,14}", dia);
        }

        Console.WriteLine();

        for (int i = 0; i < 3; i++)
        {
            Console.Write("{0,-15}", "Sucursal " + (i + 1));

            for (int j = 0; j < 5; j++)
            {
                Console.Write("{0,14:N0}", matrizVentas[i, j]);
            }

            Console.WriteLine();
        }
    }

    public double CalcularTotalPorSucursal(int indiceSucursal)
    {
        double total = 0;

        if (indiceSucursal >= 0 && indiceSucursal < 3)
        {
            for (int j = 0; j < 5; j++)
            {
                total += matrizVentas[indiceSucursal, j];
            }
        }

        return total;
    }

    public void MostrarDiaMasVendido()
    {
        double mayorVenta = 0;
        int indiceDiaMayor = 0;

        for (int j = 0; j < 5; j++)
        {
            double totalDia = 0;

            for (int i = 0; i < 3; i++)
            {
                totalDia += matrizVentas[i, j];
            }

            if (totalDia > mayorVenta)
            {
                mayorVenta = totalDia;
                indiceDiaMayor = j;
            }
        }

        Console.WriteLine("\nDia con mayores ventas: " +
            dias[indiceDiaMayor]);

        Console.WriteLine("Total vendido: $" +
            mayorVenta.ToString("N2"));
    }
}

// ===============================
// PROGRAMA PRINCIPAL
// ===============================

public class Program
{
    static GestorInventario inventario = new GestorInventario();
    static GestorPedidos pedidos = new GestorPedidos();
    static ReporteMatriz reporte = new ReporteMatriz();

    static Sucursal[] sucursales =
    {
        new Sucursal(1, "Sucursal Centro", "Buenos Aires"),
        new Sucursal(2, "Sucursal Norte", "Vicente Lopez"),
        new Sucursal(3, "Sucursal Sur", "Lanus")
    };

    static int siguienteIdVenta = 1;
    static int siguienteIdPedido = 1;

    static void Main(string[] args)
    {
        inventario.CargarProductosIniciales();
        reporte.CargarVentasSimuladas();

        int opcion = 0;

        while (opcion != 6)
        {
            MostrarMenu();

            opcion = LeerEntero("Seleccione una opcion: ");

            ProcesarOpcion(opcion);

            if (opcion != 6)
            {
                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();
            }
        }
    }

    static void MostrarMenu()
    {
        Console.WriteLine("\n==================================");
        Console.WriteLine(" SISTEMA DE GESTION TECHSTORE");
        Console.WriteLine("==================================");
        Console.WriteLine("1. Ver Catalogo y Precios de Venta");
        Console.WriteLine("2. Registrar un Pedido");
        Console.WriteLine("3. Registrar Entrega de Pedido");
        Console.WriteLine("4. Ver Matriz de Ventas Semanales");
        Console.WriteLine("5. Ver Reporte de Sucursal con Mayor Venta");
        Console.WriteLine("6. Salir");
        Console.WriteLine("==================================");
    }

    static void ProcesarOpcion(int opcion)
    {
        switch (opcion)
        {
            case 1:
                inventario.MostrarCatalogo();
                break;

            case 2:
                RegistrarPedido();
                break;

            case 3:
                RegistrarEntrega();
                break;

            case 4:
                reporte.MostrarMatrizVentas();
                reporte.MostrarDiaMasVendido();
                break;

            case 5:
                MostrarSucursalMayorVenta();
                break;

            case 6:
                Console.WriteLine("Gracias por utilizar TechStore.");
                break;

            default:
                Console.WriteLine("Opcion invalida. Intente nuevamente.");
                break;
        }
    }

    // REGISTRAR PEDIDO

    static void RegistrarPedido()
    {
        Console.WriteLine("\n===== REGISTRAR PEDIDO =====");

        if (pedidos.HayEspacio() == 0)
        {
            Console.WriteLine("No hay espacio para registrar mas pedidos.");
            return;
        }

        inventario.MostrarProductosConStock();

        int idProducto = LeerEntero("Ingrese el ID del producto: ");

        Producto producto = inventario.BuscarProductoPorId(idProducto);

        if (producto == null)
        {
            Console.WriteLine("El producto no existe.");
            return;
        }

        if (producto.Stock <= 0)
        {
            Console.WriteLine("El producto no tiene stock disponible.");
            return;
        }

        producto.MostrarInfo();

        int cantidad = LeerEntero("Ingrese la cantidad solicitada: ");

        if (cantidad <= 0)
        {
            Console.WriteLine("La cantidad debe ser mayor que cero.");
            return;
        }

        if (producto.Stock < cantidad)
        {
            Console.WriteLine("Stock insuficiente.");
            Console.WriteLine("Stock disponible: " + producto.Stock);
            return;
        }

        // SELECCIONAR SUCURSAL

        Console.WriteLine("\nSucursales disponibles:");

        for (int i = 0; i < sucursales.Length; i++)
        {
            Console.WriteLine((i + 1) + ". " +
                sucursales[i].Nombre + " - " +
                sucursales[i].Ciudad);
        }

        int sucursalElegida = LeerEntero(
            "Seleccione el destino del pedido (1-3): ");

        if (sucursalElegida < 1 || sucursalElegida > 3)
        {
            Console.WriteLine("Destino invalido.");
            return;
        }

        // SELECCIONAR DIA

        Console.WriteLine("\nDias disponibles:");

        string[] dias =
        {
            "Lunes", "Martes", "Miercoles", "Jueves", "Viernes"
        };

        for (int i = 0; i < dias.Length; i++)
        {
            Console.WriteLine((i + 1) + ". " + dias[i]);
        }

        int diaElegido = LeerEntero("Seleccione el dia (1-5): ");

        if (diaElegido < 1 || diaElegido > 5)
        {
            Console.WriteLine("Dia invalido.");
            return;
        }

        // CALCULAR PRECIO Y DESCUENTO

        double precioUnitario = producto.CalcularPrecioVenta(30);

        double montoInicial = precioUnitario * cantidad;

        Venta venta = new Venta(
            siguienteIdVenta,
            idProducto,
            cantidad,
            montoInicial
        );

        double montoFinal = venta.AplicarDescuento(10);

        // CALCULAR COSTO DE ENVIO

        double costoEnvio = CalcularCostoEnvio(sucursalElegida);

        double totalPagar = montoFinal + costoEnvio;

        // CREAR PEDIDO

        Pedido nuevoPedido = new Pedido(
            siguienteIdPedido,
            idProducto,
            producto.Nombre,
            cantidad,
            sucursales[sucursalElegida - 1].Nombre,
            costoEnvio
        );

        pedidos.AgregarPedido(nuevoPedido);

        // ACTUALIZAR STOCK

        inventario.ActualizarStock(idProducto, cantidad);

        // ACTUALIZAR MATRIZ DE VENTAS

        reporte.AgregarVenta(
            sucursalElegida - 1,
            diaElegido - 1,
            montoFinal
        );

        // MOSTRAR RESULTADO

        Console.WriteLine("\n===== PEDIDO REGISTRADO =====");

        Console.WriteLine("Numero de pedido: " + siguienteIdPedido);
        Console.WriteLine("Producto: " + producto.Nombre);
        Console.WriteLine("Cantidad: " + cantidad);

        Console.WriteLine("Precio unitario: $" +
            precioUnitario.ToString("N2"));

        Console.WriteLine("Subtotal: $" +
            montoInicial.ToString("N2"));

        if (cantidad > 5)
        {
            Console.WriteLine("Descuento aplicado: 10%");
        }
        else
        {
            Console.WriteLine("Descuento aplicado: 0%");
        }

        Console.WriteLine("Total de productos: $" +
            montoFinal.ToString("N2"));

        Console.WriteLine("Costo de envio: $" +
            costoEnvio.ToString("N2"));

        Console.WriteLine("TOTAL A PAGAR: $" +
            totalPagar.ToString("N2"));

        Console.WriteLine("Sucursal: " +
            sucursales[sucursalElegida - 1].Nombre);

        Console.WriteLine("Dia: " + dias[diaElegido - 1]);

        Console.WriteLine("Estado del pedido: Pendiente");

        Console.WriteLine("Stock restante: " + producto.Stock);

        siguienteIdVenta++;
        siguienteIdPedido++;
    }

    // CALCULAR COSTO DE ENVIO

    static double CalcularCostoEnvio(int sucursal)
    {
        double costo = 0;

        if (sucursal == 1)
        {
            costo = 3000;
        }
        else if (sucursal == 2)
        {
            costo = 4500;
        }
        else if (sucursal == 3)
        {
            costo = 5000;
        }

        return costo;
    }

    // REGISTRAR ENTREGA

    static void RegistrarEntrega()
    {
        Console.WriteLine("\n===== REGISTRAR ENTREGA =====");

        int cantidad = pedidos.MostrarPedidosPendientes();

        if (cantidad == 0)
        {
            Console.WriteLine("No hay pedidos pendientes.");
            return;
        }

        int idPedido = LeerEntero(
            "\nIngrese el numero de pedido a entregar: ");

        int resultado = pedidos.RegistrarEntrega(idPedido);

        if (resultado == 1)
        {
            Console.WriteLine("Pedido entregado correctamente.");
        }
        else if (resultado == 0)
        {
            Console.WriteLine("El numero de pedido no existe.");
        }
        else
        {
            Console.WriteLine("El pedido ya fue entregado.");
        }
    }

    // REPORTE DE SUCURSAL CON MAYOR VENTA

    static void MostrarSucursalMayorVenta()
    {
        Console.WriteLine("\n===== REPORTE POR SUCURSAL =====");

        double mayorVenta = -1;
        int indiceMayor = 0;

        for (int i = 0; i < sucursales.Length; i++)
        {
            double total = reporte.CalcularTotalPorSucursal(i);

            Console.WriteLine(sucursales[i].Nombre +
                ": $" + total.ToString("N2"));

            if (total > mayorVenta)
            {
                mayorVenta = total;
                indiceMayor = i;
            }
        }

        Console.WriteLine("\nSucursal con mayor venta: " +
            sucursales[indiceMayor].Nombre);

        Console.WriteLine("Total vendido: $" +
            mayorVenta.ToString("N2"));

        sucursales[indiceMayor].MostrarDetalle();
    }

    // LEER NUMEROS ENTEROS

    static int LeerEntero(string mensaje)
    {
        int valor = 0;
        int resultado = 0;

        while (resultado == 0)
        {
            Console.Write(mensaje);

            try
            {
                valor = Convert.ToInt32(Console.ReadLine());
                resultado = 1;
            }
            catch
            {
                Console.WriteLine(
                    "Entrada invalida. Ingrese un numero entero.");
            }
        }

        return valor;
    }
}
