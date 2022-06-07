using System;
public class Empleado{
    public string puesto;

    public Empleado(String puesto){
        this.puesto=puesto;
    }

    public int producirHambur(){
        Random random = new Random();
        int segundos = random.Next(30, 50); //intervalo de produccion
        
        return segundos;
    }

    public int pagar(int hambur){
        int tiempoTotal =45; //tiempo transcurrido al pagar
        int tiempoPorHambur =10;
        
        if(hambur==1){
            return tiempoTotal+tiempoPorHambur;
        }else if(hambur==2){
            tiempoPorHambur*=2;
            return tiempoTotal+tiempoPorHambur;
        }else if(hambur==3){
            tiempoPorHambur*=3;
            return tiempoTotal+tiempoPorHambur;
        }else if(hambur==4){
            tiempoPorHambur*=4;
            return tiempoTotal+tiempoPorHambur;
        }else if(hambur==5){
            tiempoPorHambur*=5;
            return tiempoTotal+tiempoPorHambur;
        }else {
            tiempoPorHambur*=6;
            return tiempoTotal+tiempoPorHambur;
        }
    }

}

