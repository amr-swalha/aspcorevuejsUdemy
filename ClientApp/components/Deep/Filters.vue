<template>
    <div>
        <h1 v-once>{{msg}}</h1>
        <h3>Creating Filters</h3>
        <p>{{test | AllCaps | AllSmall}}</p>
        <h3>Filters in v-bind</h3>
        <input type="text" v-bind:value="test | AllCaps | AllSmall" />
    </div>
</template>

<script>
    
    export default {
        data() {
            return {
                msg: 'Filters',
                test: "test"
            }
        },
        methods: {
            Update: function () {
                this.msg = "test";
            }
        },
        filters: {
            AllCaps: function (val) {
                if (val == '') {
                    return val;
                }
                console.log("will be capital: "+val);
                return val.toUpperCase();
            },
            AllSmall: function (val) {
                if (val == '') {
                    return val;
                }
                console.log("will be small: " +val);
                return val.toLowerCase();
            }
        }
    }
</script>

<style>

</style>
