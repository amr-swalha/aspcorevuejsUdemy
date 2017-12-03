<template>
    <div>
        <h1>{{msg}}</h1>
        <h3>Simple Method Declartion</h3>
        <button @click="Hello()">Show Msg</button><br />
        <h3>Passing Parameters To Method</h3>
        <button @click="Pass(1)">Pass Parameters</button><br />
        <h3>Interpolation</h3>
        Value is: {{simpleText()}}
        <br />
        <h3>Calling Other Methods</h3>
        <button @click="callOther()">Calling Other Methods</button>
        <br />
    </div>
</template>

<script>
    export default {
        data() {
            return {
                msg: 'Methods'
            }
        },
        methods: {
            Hello: function () {
                alert("Hello World!");
            },
            Pass: function (val1) {
                alert("Value is: "+val1);
            },
            simpleText: function () {
                return 'hello world from interpolation'
            },
            callOther: function () {
                this.Pass(5);
            }
        },
        created: function () {
            
        }
    }
</script>

<style>
</style>
