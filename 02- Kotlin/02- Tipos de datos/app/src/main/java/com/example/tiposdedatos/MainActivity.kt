package com.example.tiposdedatos

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
    }

    private  fun tiposDeDatos(){

        // La infiencia de tipos es que el compilador deduce el tipo de dato que es
        // Tipo de dato String
        val nombre = "Eduardo"
        val apellido = "Martin-Sonseca"
        val nombreCompleto = "$nombre $apellido"
        println(nombreCompleto)

        // Tipo de dato Enteros (Byte, Short, Int, Long)

        val int = 1
        val int2 = 2
        val sumaNumeros = int + int2
        println(sumaNumeros)

        // Tipo de dato Float y Double

        val double1 = 1.5
        val double2 = 2.6
        val double3 = 1
        val sumaDouble = double1 + double2 + double3
        println(sumaDouble)

        // Tipo de dato Boolean

        val myBool = true
        val myBool2 = false
        val myBool3 = myBool && myBool2
        println(myBool == myBool2)
        println(myBool && myBool2) 





    }
}