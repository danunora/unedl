package com.dnunora;

public class AnotherThread extends Thread{

    @Override
    public void run() {
        System.out.println("Hello from ANOTHER thread");
    }
}
