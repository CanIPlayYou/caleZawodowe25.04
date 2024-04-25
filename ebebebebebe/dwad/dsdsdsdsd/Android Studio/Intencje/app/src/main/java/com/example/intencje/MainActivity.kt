package com.example.intencje

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button
import android.widget.TextView

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        val save=findViewById<Button>(R.id.buttonPrzeslij);
        val wiadomosc=findViewById<TextView>(R.id.tekst);

        save.setOnClickListener{
            val intent = Intent(this, MainActivity2::class.java)

            intent.putExtra("wiadomosc", wiadomosc.text.toString())
            startActivity(intent);


        }
    }

    fun wyslijWiadomosc(){

    }
}