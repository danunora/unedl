package com.dnunora;

public class Main {

    public static void main(String[] args) {
	// write your code here
        System.out.println("Hello from the MAIN thread");
        Thread anotherThread = new AnotherThread();
        anotherThread.start();

        // Anonymous class
        new Thread(){
            public void run() {
                System.out.println("Hello from ANONYMOUS class thread");
            }
        }.start();

        System.out.println("Hello AGAIN from the MAIN thread");

    }
}
