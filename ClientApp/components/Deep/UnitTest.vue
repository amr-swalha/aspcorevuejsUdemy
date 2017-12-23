<template>
    <div>
        <h1 v-once>{{msg}}</h1>
        <h3>Creating a custom directive</h3>
    </div>
</template>

<script>
    
    export default {
        data() {
            return {
                msg: 'Unit Testing',
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
