package com.example.zadaniedwa

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button
import android.widget.ImageView
import android.widget.TextView
import java.util.Objects

class MainActivity : AppCompatActivity() {

    var licznik = 0;

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)


        val btnLewo:Button = findViewById(R.id.btn)
        val btnPrawo:Button = findViewById(R.id.btn2)
        val img:ImageView = findViewById(R.id.imagetest)

        btnLewo.setOnClickListener{
            licznik--;
            img.setImageResource(R.drawable.imgtest)
        }

        btnPrawo.setOnClickListener{
            licznik++;

            if(licznik == 0){
                img.setImageResource(R.drawable.imgtest0)
            }
            if(licznik == 1){
                img.setImageResource(R.drawable.imgtest1)
            }
            if(licznik == 2){
                img.setImageResource(R.drawable.imgtest2)
            }
        }
    }
}
