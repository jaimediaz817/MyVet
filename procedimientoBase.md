

#1 Ajustes para agregar las referencias Common y DAL al proyecto web

#2 Owner y DataContext deben ser clases publicas

#3 Ejecutar en orden los siguientes comandos de la consola de Nuguet:
PM> update-database
PM> add-migration InitialDb
PM> update-database

#4 una vez creamos las entidades con sus respectivas relaciones desde las clases, se procede a guardar y a crear en el DataContext, cada entidad:
        // cuales enties vamos a mapear en la base de datos
        public DbSet<Agenda> Agendas{ get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<Pet> pets { get; set; }
        public DbSet<PetType> petTypes { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }
        public DbSet<Owner> Owners { get; set; }


#5  Corrijo los errores presentados y ejecuto:
add-migration CompleteDB
update-database

drop-database

await a un método asincrono, es para tirar el proceso por otro hilo de procesamiento, performance


# creando nuevo entity:

- adicionar una clase User