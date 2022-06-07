Shader "Unlit/SeeThrough"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
    }
    SubShader
    {
        Tags { "Queue" = "Transparent+2"} //3002 queue

        Pass { Blend Zero One}
        
    }
}
