<template>
    <div>
        <h1 v-once>{{msg}}</h1>
        <h3>Creating a custom directive</h3>
        <p>It's recommended to have it in a shared file</p>
        <p>Directives can be declared globally or locally </p>
        <p>To add a directive start with an empty JS file</p>
        <p>Then specify the directive name on the element starting with v-</p>
       <input type="text" v-change-color="color" /><br/>
       <input type="text" v-model="color"/>
    </div>
</template>

<script>
    
    export default {
        data() {
            return {
                msg: 'Custom Directives',
                test: "test",
                color:'blue'
            }
        },
        methods: {
            Update: function () {
                this.msg = "test";
            }
        }
    }
</script>

<style>
    .redCss {
        color: red;
    }
</style>
