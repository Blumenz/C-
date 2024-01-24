namespace ProyectoHerencia
{



    class Program
    {
        static void Main(string[] args)
        {

            Caballo miBabieca = new Caballo("Babieca");

            Humano miJuan = new Humano("Juan");

            Gorila miCopito = new Gorila("Copito");

            Mamiferos animal = new Mamiferos("Bucefalo");

            Caballo Bucefalo = new Caballo("Bucefalo");

            Object miAnimal = new Caballo("Bucefalo");

            Object miPersona = new Humano("Roberto");

            Object miMamifero = new Mamiferos("Wally");

            /*Mamiferos persona = new Humano("Roberto");

            persona.*/


            Mamiferos[] almacenAnimales = new Mamiferos[3];

            almacenAnimales[0] = miBabieca;

            almacenAnimales[1] = miJuan;

            almacenAnimales[2] = miCopito;

            almacenAnimales[1].getNombre();


            //miJuan.getNombre();
    
            for (int i = 0; i < almacenAnimales.Length; i++)
            {
                almacenAnimales[i].pensar();
            }
         }
    }

    class Mamiferos
    {
        public Mamiferos(String nombre)
        {
            nombreSerVivo = nombre;
        }

        public void getNombre()
        {
            Console.WriteLine("El nombre del ser vivo es " +nombreSerVivo);
        }

        public void respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }

        public virtual void pensar()
        {
            Console.WriteLine("Poseo pensamieno instintivo");
        }
        public void cuidarCrias()
        {

            Console.WriteLine("Cuido de mis crias");

        }

        private String nombreSerVivo;
    }

    class Caballo : Mamiferos
        {
            public Caballo(String nombreCaballo) : base(nombreCaballo)
        {

        }

            public void galopar()
            {

                Console.WriteLine("Soy capaz de galopar");

            }
        }

        class Humano : Mamiferos
        {
            public Humano(String nombreHumano) : base(nombreHumano) { }

            public override void pensar()
            {
                Console.WriteLine("Soy capaz de pensar");
            }

            

        }

        class Gorila : Mamiferos
        {
                public Gorila(String nombreGorila):base(nombreGorila) { }
                public void trepar()
                {

                    Console.WriteLine("Soy capaz de trepar");

                }
        }
    }
