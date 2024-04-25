package com.example.imageview

import android.media.Image
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button
import android.widget.EditText
import android.widget.ImageView
import android.widget.TextView
import android.widget.Toast

class MainActivity : AppCompatActivity() {
    var licznik = 0;

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        val img = findViewById<ImageView>(R.id.image)

        img.setImageResource(R.drawable.zdjecietestowe)


        val edit:EditText = findViewById(R.id.editText)
        val btn:Button = findViewById(R.id.buttonEditTextSend)
        val textVieww:TextView = findViewById(R.id.textViewWynik)

        btn.setOnClickListener{
            licznik++;
            textVieww.setText(""+licznik);

            val text = edit.text;
            Toast.makeText(this, "Witaj "+ text,
                Toast.LENGTH_LONG).show()
        }
    }
}