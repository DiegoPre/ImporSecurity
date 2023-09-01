using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ETITC.Models;

public partial class ImporsecurityContext : DbContext
{
    public ImporsecurityContext()
    {
    }

    public ImporsecurityContext(DbContextOptions<ImporsecurityContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CategoriaProducto> CategoriaProductos { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Factura> Facturas { get; set; }

    public virtual DbSet<MetodoPago> MetodoPagos { get; set; }

    public virtual DbSet<OrdenCompra> OrdenCompras { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Proveedor> Proveedors { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-ALMS\\SQLEXPRESS; Database=IMPORSECURITY; Trusted_Connection=True; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CategoriaProducto>(entity =>
        {
            entity.HasKey(e => e.IdCategoria);

            entity.ToTable("Categoria_Producto");

            entity.Property(e => e.IdCategoria)
                .ValueGeneratedNever()
                .HasColumnName("Id_Categoria");
            entity.Property(e => e.DescripcionCategoria)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Descripcion_Categoria");
            entity.Property(e => e.NombreCategoria)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Nombre_Categoria");
            entity.Property(e => e.ValorIvaProducto)
                .HasDefaultValueSql("((0.19))")
                .HasColumnName("Valor_Iva_Producto");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.IdUsuario);

            entity.ToTable("Cliente");

            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
            entity.Property(e => e.Apellido)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Ciudad)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Direccion).HasColumnType("text");
            entity.Property(e => e.Email)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.IdRol)
                .HasDefaultValueSql("((2))")
                .HasColumnName("Id_Rol");
            entity.Property(e => e.NoDoc)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Pais)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Tipo_Doc");
        });

        modelBuilder.Entity<Factura>(entity =>
        {
            entity.HasKey(e => e.IdFactura);

            entity.ToTable("Factura");

            entity.Property(e => e.IdFactura).HasColumnName("Id_Factura");
            entity.Property(e => e.FechaFactura)
                .HasColumnType("date")
                .HasColumnName("Fecha_Factura");
            entity.Property(e => e.IdMetodoPago).HasColumnName("Id_Metodo_Pago");
            entity.Property(e => e.IdOrden).HasColumnName("Id_Orden");
            entity.Property(e => e.VrFlete)
                .HasDefaultValueSql("((0.00))")
                .HasColumnName("Vr_Flete");
            entity.Property(e => e.VrImpuestos)
                .HasDefaultValueSql("((0.00))")
                .HasColumnName("Vr_Impuestos");
            entity.Property(e => e.VrTotalPago).HasColumnName("Vr_Total_Pago");
            entity.Property(e => e.VrVentaFactura).HasColumnName("Vr_Venta_Factura");
        });

        modelBuilder.Entity<MetodoPago>(entity =>
        {
            entity.HasKey(e => e.IdMetodoPago);

            entity.ToTable("Metodo_Pago");

            entity.Property(e => e.IdMetodoPago)
                .ValueGeneratedNever()
                .HasColumnName("Id_Metodo_Pago");
            entity.Property(e => e.NombreMetodoPago)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Metodo_Pago");
        });

        modelBuilder.Entity<OrdenCompra>(entity =>
        {
            entity.HasKey(e => e.IdOrden);

            entity.ToTable("Orden_Compra");

            entity.Property(e => e.IdOrden).HasColumnName("Id_Orden");
            entity.Property(e => e.CantidadItem).HasColumnName("Cantidad_Item");
            entity.Property(e => e.FechaOrden)
                .HasColumnType("date")
                .HasColumnName("Fecha_Orden");
            entity.Property(e => e.IdProducto).HasColumnName("Id_Producto");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
            entity.Property(e => e.VrTotal).HasColumnName("Vr_Total");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.IdProducto);

            entity.ToTable("Producto");

            entity.Property(e => e.IdProducto)
                .ValueGeneratedNever()
                .HasColumnName("Id_Producto");
            entity.Property(e => e.DescripcionProducto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Descripcion_Producto");
            entity.Property(e => e.DescuentoProducto)
                .HasDefaultValueSql("((0.00))")
                .HasColumnName("Descuento_Producto");
            entity.Property(e => e.IdCategoria).HasColumnName("Id_Categoria");
            entity.Property(e => e.IdProveedor).HasColumnName("Id_Proveedor");
            entity.Property(e => e.NombreProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Producto");
            entity.Property(e => e.PrecioCompra)
                .HasDefaultValueSql("((0.00))")
                .HasColumnName("Precio_Compra");
            entity.Property(e => e.PrecioVenta).HasColumnName("Precio_Venta");
        });

        modelBuilder.Entity<Proveedor>(entity =>
        {
            entity.HasKey(e => e.IdProveedor);

            entity.ToTable("Proveedor");

            entity.Property(e => e.IdProveedor)
                .ValueGeneratedNever()
                .HasColumnName("Id_Proveedor");
            entity.Property(e => e.CiudadProveedor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Ciudad_Proveedor");
            entity.Property(e => e.DireccionProveedor)
                .HasColumnType("text")
                .HasColumnName("Direccion_Proveedor");
            entity.Property(e => e.EmailProveedor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Email_Proveedor");
            entity.Property(e => e.NombreProveedor)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Nombre_Proveedor");
            entity.Property(e => e.PaisProveedor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Pais_Proveedor");
            entity.Property(e => e.TelefonoProveedor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Telefono_Proveedor");
            entity.Property(e => e.WebProveedor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Web_Proveedor");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.IdRol);

            entity.Property(e => e.IdRol).HasColumnName("Id_Rol");
            entity.Property(e => e.Estado)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'Inactivo')")
                .IsFixedLength();
            entity.Property(e => e.NombreRol)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Nombre_Rol");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
