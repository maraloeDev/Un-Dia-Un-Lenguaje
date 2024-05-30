# Clases self es el mismo

class MyEmptyPerson:
    pass


print(MyEmptyPerson)
print(type(MyEmptyPerson()))


class MyPerson:

    # Constructor de clase
    def __init__(self, name, surname, alias):
        self.fullname = f"{name} {surname}"

    def get_name(self):
        return self.name

    def walk(self):
        print(f"{self.fullname} esta caminando")


my_person = MyPerson("Eduardo", "Martín-Sonseca", "maraloeDev")

print(my_person.fullname)
my_person.walk()

my_other_person = MyPerson("Eduardo", "Martín-Sonseca", "maraloeDev")
print(my_other_person.fullname)

my_other_person.fullname = "Maraloed"
print(my_other_person.fullname)
