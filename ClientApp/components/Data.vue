<template>
    <div>
        <h1>{{msg}}</h1>
        <h3>Contains the properties used through the component</h3>
        <span>Can be accessed via Interpolation : {{simple}}</span>
        <br />
        <h3>Can be also accessed via methods</h3>
        <span>Here is the value: {{value}}</span><br />
        <button @click="Update()">change value</button>
        <br />
        <h3>Can be also access complex objects</h3>
        <span>Here is the value: {{complex.first}}</span><br />
    </div>
</template>

<script>
    export default {
        data() {
            return {
                msg: 'Data Section',
                simple: `Simple Text`,
                value: 'Normal',
                complex: {
                    first:1
                }
            }
        },
        methods: {
            Update: function () {
                this.value = "New Value!";
            }
        }
    }
</script>

<style>

</style>
