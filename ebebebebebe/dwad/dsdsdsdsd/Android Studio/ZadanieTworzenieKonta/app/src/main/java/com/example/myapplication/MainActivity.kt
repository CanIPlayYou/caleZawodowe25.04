package com.example.myapplication

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button
import android.widget.EditText
import android.widget.TextView

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        val emailText:EditText = findViewById(R.id.emailEditText)
        val passText:EditText = findViewById(R.id.passEditText)
        val repPassText:EditText = findViewById(R.id.repPassEditText)

        val btnZat:Button = findViewById(R.id.buttonZatw)
        val wynikText:TextView = findViewById(R.id.wynik)

        btnZat.setOnClickListener(){
            if(emailText.text.contains("@") && passText.text.toString() == repPassText.text.toString()){
                wynikText.text = "Witaj "+ emailText.text
            }

            if(!emailText.text.contains("@")){
                wynikText.text = "Błędny email"
            }

            if(passText.text.toString() != repPassText.text.toString()){
                wynikText.text = "Hasła się różnią"
            }
        }
    }
}