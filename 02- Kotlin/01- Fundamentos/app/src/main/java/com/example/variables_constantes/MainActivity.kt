package com.example.variables_constantes

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
    }

    private fun variablesYConstantes() {
        // Variables  a la hora de nombrar una variable se utiliza la palabra reservada var, e tipo de dato lo detecta automaticamente
        var miprimeraVariable = "Hola mundo desde Kotlin"
        var myFirstNumber = 1

        println(miprimeraVariable)
        println(myFirstNumber)


        // Se cambia el valor de la variable
        miprimeraVariable = "Bienvenidos a Android Studio"
        myFirstNumber = 2
        // Se imprime el nuevo valor de la variable
        println(miprimeraVariable)
        println(myFirstNumber)

        // No se puede asignar un tipo Int a una variable de tipo String
        // miprimeraVariable = 3


        var miSegundaVariable = "Hola"
        println(miSegundaVariable);
        // Cambiamos el valor de la variable
        miSegundaVariable = miprimeraVariable

        println(miSegundaVariable)
        // Constantes Su valor no puede cambiar
        val constante = "Hola a todos"
        println(constante)
        // Da error al cambiar el valor de la constante por que no se puede cambiar
        // constante = "Adios";


    }
}