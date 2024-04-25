package com.example.aplikacjaegzam

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button
import android.widget.TextView

class MainActivity : AppCompatActivity() {
    var licznik = 0;

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        val btnPolub:Button = findViewById(R.id.buttonPolub)
        val btnUsun:Button = findViewById(R.id.buttonUsun)
        val textPolubien:TextView = findViewById(R.id.textViewPolubienia)



        btnPolub.setOnClickListener{
            licznik++
            textPolubien.setText(""+licznik+" polubień")
        }

        btnUsun.setOnClickListener{
            licznik--

            if(licznik < 0){
                licznik = 0;
            }

            textPolubien.setText(""+licznik+" polubień")
        }

    }
}