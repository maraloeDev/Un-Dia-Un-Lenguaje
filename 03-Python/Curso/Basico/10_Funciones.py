# Funciones

def my_function():
    print("Esto es una funcion")


my_function()


def sum_two_values(first_number, second_number):
    print(first_number + second_number)


sum_two_values(7, 4)


def sum_two_values_with_return(first_number, second_number):
    return first_number + second_number


my_result = sum_two_values_with_return(2, 14)
print(my_result)


def print_name(name, surname, alias = "Sin alias"):
    print(f"{name} , {surname}, {alias}")


print_name(name="Eduardo", surname="Martín-Sonseca")


def print_upper_texts(*texts): # Parametros dinamicos: es para introducir cualquier parametro
    for textos in texts:
        print(textos.upper())


print_upper_texts("Hola", "Carlos")
print_upper_texts("Hola")
