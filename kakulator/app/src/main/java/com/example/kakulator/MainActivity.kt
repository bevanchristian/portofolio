package com.example.kakulator
import android.os.Bundle
import android.text.method.ScrollingMovementMethod
import android.widget.Toast
import androidx.appcompat.app.AppCompatActivity
import kotlinx.android.synthetic.main.activity_main.*
import net.objecthunter.exp4j.ExpressionBuilder

open class MainActivity : AppCompatActivity() {
    lateinit var simpan:String
    var jumlah=0
    var counter=0
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        hasil.setMovementMethod(ScrollingMovementMethod())
        hasil2.setMovementMethod(ScrollingMovementMethod())
        tombol()
    }

    private fun tombol(){
        angka()
        bukanangka()
        matematik()
        hapus()
    }


    private fun angka(){
        var kumpulanagka= mapOf(satu to "1",dua to "2",tiga to "3",empat to "4" ,lima to "5", enam to "6", tujuh to "7",delapan to "8",sembilan to "9" ,nol to "0",titik to ".")
        for (x in kumpulanagka){
            x.key.setOnClickListener { penulisan(x.value,0) }
        }
    }

    private fun bukanangka(){
        var kumpulanoperator= mapOf(tambah to "+",kurang to "-", bagi to "/",kali to "*",pangkat to "^")
        for (c in kumpulanoperator){
            c.key.setOnClickListener { penulisan(c.value,1) }
        }
    }

    fun matematik(){
        try {
            akar.setOnClickListener {akar() }
            round.setOnClickListener {round()}
            up.setOnClickListener { up()}
            floor.setOnClickListener {floor()}
            samadengan.setOnClickListener { samadengan() }
        }catch (e:Exception){
            hasil.text=""
            hasil2.text=""
            Toast.makeText(this,"maaf isikan dengan angka",Toast.LENGTH_SHORT).show()
        }

    }




    private fun hapus(){
        ac.setOnClickListener {
            hasil.text=""
            hasil2.text=""
        }
        c.setOnClickListener {
            hasil2.text="" }


        delete.setOnClickListener {
            if (hasil.text.isNotBlank()){
                hasil.text=hasil.text.substring(0,hasil.length()-1)
            }
        }
    }




    private fun samadengan(){
        try {
            val expression=ExpressionBuilder(hasil.text.toString()).build()
            val resul=expression.evaluate()
            val longresult=resul.toLong()
            if(resul==longresult.toDouble()){
                hasil2.text=longresult.toString()
            }else{
                hasil2.text=resul.toString()
            }

        }catch (e:Exception){
            println("error")

        }
    }





    private fun floor(){
        try {
            if(hasil2.text.isNotEmpty()){
                var a=hasil2.text.toString()
                hasil.text=Math.floor(a.toDouble()).toInt().toString()
                hasil2.text=""
            }else{
                var a=hasil.text.toString()
                hasil.text=Math.floor(a.toDouble()).toInt().toString()
            }
        }catch (e:Exception){
            hasil.text=""
            hasil2.text=""
            Toast.makeText(this,"maaf isikan dengan angka",Toast.LENGTH_SHORT).show()
        }
    }
    private fun up(){
        try {
            if(hasil2.text.isNotEmpty()){
                var a=hasil2.text.toString()
                hasil.text=Math.ceil(a.toDouble()).toInt().toString()
                hasil2.text=""
            }else{
                var a=hasil.text.toString()
                hasil.text=Math.ceil(a.toDouble()).toInt().toString()
            }
        }catch (e:Exception){
            hasil.text=""
            hasil2.text=""
            Toast.makeText(this,"maaf isikan dengan angka",Toast.LENGTH_SHORT).show()
        }
    }
    private fun round(){
        try {
            if (hasil2.text.isNotEmpty()){
                var a=hasil2.text.toString()
                hasil.text=(Math.round(a.toDouble()*10.0)/10.0).toString()
                hasil2.text=""
            }else{
                var a=hasil.text.toString()
                hasil.text=(Math.round(a.toDouble()*10.0)/10.0).toString()
            }
        }catch (e:Exception){
            hasil.text=""
            hasil2.text=""
            Toast.makeText(this,"maaf isikan dengan angka",Toast.LENGTH_SHORT).show()
        }


    }
    private fun akar(){
        try {
            if (hasil2.text.isNotEmpty()){
                var a=hasil2.text.toString()
                hasil.text=Math.sqrt(a.toDouble()).toString()
                hasil2.text=""
            }else{
                var a=hasil.text.toString()
                hasil.text=Math.sqrt(a.toDouble()).toString()
            }
        }catch (e:Exception){
            hasil.text=""
            hasil2.text=""
            Toast.makeText(this,"maaf isikan dengan angka",Toast.LENGTH_SHORT).show()
        }


    }
    private fun penulisan(nilai:String, operator: Int){
        try {
            if(hasil2.text.isNotEmpty()){
                hasil.text=""

            }
            if(operator==0){
                counter=0
                hasil.append(hasil2.text)
                hasil.append(nilai)
                hasil2.text=""
            }
            else{
             counter=counter+1
if (counter<=1){
    hasil.append(hasil2.text)
    hasil2.text=""
    hasil.append(nilai)
}




            }
        }catch (e:Exception){

        }


    }
    }
/* satu.setOnClickListener { penulisan("1",0) }
    dua.setOnClickListener { penulisan("2",0) }
    tiga.setOnClickListener { penulisan("3",0) }
    empat.setOnClickListener { penulisan("4",0) }
    lima.setOnClickListener { penulisan("5",0) }
    enam.setOnClickListener { penulisan("6",0) }
    tujuh.setOnClickListener { penulisan("7",0) }
    delapan.setOnClickListener { penulisan("8",0) }
    sembilan.setOnClickListener { penulisan("9",0) }
    nol.setOnClickListener { penulisan("0",0) }
    titik.setOnClickListener { penulisan(".",0) } */


