public class Main {

    /**
    @Singleton*/
    public static final class PersonSingle {
        private static PersonSingle INSTANCE;
        private PersonSingle() {
        }
        public static PersonSingle getInstance() {
            if(INSTANCE == null) {
                INSTANCE = new PersonSingle();
            }
            return INSTANCE;
        }
    }

    /**
    @Builder
    */
    /*
    Najpopularniejszym wzorcem moim zdaniem jest builder po singletonie(Ponieważ jest jeszcze prostszy w zrozumieniu).
    Jest on wzorcem kreacyjnym, który pozwala oddzielić proces tworzenia obiektu od jego reprezentacji.
    Można go spotkać naprawdę w wielu miejscach.
    Najczęściej jest używany do tworzenia obiektów DTO.
    Jest on też nieodłącznym elementem obiektów niezmiennych (immutable),
    Można go stosować w zasadzie do dowolnego rodzaju obiektów.
    Builder jest jednym z prostszych wzorców do zastosowania, czy zrozumienia.
    Można go zaimplementować na wiele sposobów.
    Można także użyć różnych narzędzi do generowania takiego buildera np. pluginy do środowiska programistycznego.
    Sprawdzić Lombok(biblioteka, która ma anotacje @builder która tworzy Builder)

    * */

    public static class Person {
        private String name;
        private int age;
        public static Builder builder() {
            return new Builder();
        }
        public static class Builder {
            private Person person = new Person();

            public Builder name(String name) {
                person.name = name;
                return this;
            }
            public Builder age(int age) {
                person.age = age;
                return this;
            }
            public Person build() {
                return person;
            }
        }
        // ... getters ...
    }

    /**Dekorator
     *
     */

    public interface Car {
        public void assemble();
    }

    public static class BasicCar implements Car {
        @Override
        public void assemble() {
            System.out.print("Basic Car.");
        }
    }

    public static class CarDecorator implements Car {
        protected Car car;
        public CarDecorator(Car c){
            this.car=c;
        }
        @Override
        public void assemble() {
            this.car.assemble();
        }
    }

    public static class SportsCar extends CarDecorator {
        public SportsCar(Car c) {
            super(c);
        }
        @Override
        public void assemble(){
            super.assemble();
            System.out.print(" Adding features of Sports Car.");
        }
    }

    public static class LuxuryCar extends CarDecorator {
        public LuxuryCar(Car c) {
            super(c);
        }
        @Override
        public void assemble(){
            super.assemble();
            System.out.print(" Adding features of Luxury Car.");
        }
    }

    public static void main(String[] args) {
        //Singleton
        PersonSingle pS = PersonSingle.getInstance();
        //Builder
        Person p = new Person();
        p.builder().name("Olek").age(12).build();
        //Dekorator
        Car sportsCar = new SportsCar(new BasicCar());
        sportsCar.assemble();
        System.out.println("\n*****");
        Car sportsLuxuryCar = new SportsCar(new LuxuryCar(new BasicCar()));
        sportsLuxuryCar.assemble();
    }
}
