package com.example.sentenciasif

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

    sentenciaIfElse()
        sentenciaWhen()
        sentenciaLoops()
    }



    private fun sentenciaIfElse(){
        val numero = 10

        // Un operador condicional para evaluar una condición
        // Operador condicional: > mayor que
        // Operadro condicional: < menor que
        // Operador condicional: >= mayor o igual que
        // Operador condicional: <= menor o igual que
        // Operador condicional: == igual que
        // Operador condicional: != diferente que

        if(numero < 10) {
            println("$numero es menor o igual que 10")
            } else {
            println("$numero es mayor que 10")
        }

        // Operador Logico: && AND
        // Operador Logico: || OR
        // Operador Logico: ! NOT

        if(numero > 10 && numero > 5) {
            println("$numero es mayor que 10 y menor que 20 y operador logica mayor que 5")
        } else {
            println("$numero no es mayor que 10 y menor que 20")
        }
    }

    private fun sentenciaWhen() {
        val country = "España"

        when(country){
            "España", "Colombia","Mexico"  -> {
                println("El idioma es Español")
            }
            "EEUU" -> {
                println("El idioma es Ingles")
            }
            "Francia" -> {
                println("El idioma es Frances")
            }
            else -> {
                println("No conocemos el idioma")
            }


        }
        val edad = 10
        when (edad){
            0,1,2 -> {
                println("Eres un bebe")
            }
            in 3.. 10 -> {
                println("Eres un niño")
            }
            in 11.. 17 -> {
                println("Eres un adolescente")
            }
            in 18.. 69 -> {
                println("Eres un adulto")
            }
            in 70..99 -> {
                println("Eres un anciano")
            }
            else -> {
                println("😱")
            }
        }
    }

    private fun sentenciaLoops() {

        // Bucles sirve para recorrer los datos

        val miarray = listOf("Hola", "Bienvenido", "Mañana es LUNES")
        val miMapa = mutableMapOf("Eduardo" to 1, "Martín-Sonseca" to 2, "Alonso" to 3)

        for ()
    }
}