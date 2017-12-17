<template>
    <div>
        <h1>{{msg}}</h1>
        <h3>A great way to share functionality across pages</h3>
       <button @click="mixinMethod()">Call Mixin</button>
    </div>
</template>

<script>
    import MyMixin from './MyMixin' //First import the mixins
    export default {
        mixins: [MyMixin], //Then add it to the declarations
        data() {
            return {
                msg: 'Mixins'
            }
        },
        methods: {
            CallMixinData: function () {
                console.log('data from mixin: ' + this.datafromMixin);
            }
        }
    }
</script>

<style>

</style>
