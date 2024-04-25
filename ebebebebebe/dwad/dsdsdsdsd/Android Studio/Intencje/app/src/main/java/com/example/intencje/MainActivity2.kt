package com.example.intencje

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.TextView

class MainActivity2 : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main2)

        val trescc = findViewById<TextView>(R.id.tresc);
        val wiadomosc = intent.getStringExtra("wiadomosc");

        trescc.setText(wiadomosc);
    }
}