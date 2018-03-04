<template>
    <div>
        <h1>{{msg}}</h1>
        <div class="form-horizontal">
            <fieldset>

                <!-- Form Name -->
                <legend>Get Item By Id</legend>

                <!-- Text input-->
                <div class="form-group">
                    <label class="col-md-4 control-label" for="textinput">Item Id</label>
                    <div class="col-md-4">
                        <input v-model="Id" placeholder="1, 2, etc." class="form-control input-md" type="text">

                    </div>
                    <input type="button" value="Get Item" @click="GetItem()" />
                </div>
                <div class="form-group">
                    <label class="col-md-4 control-label" for="textinput">Name</label>
                    <div class="col-md-4">
                        <input v-model="Item.name" placeholder="Mouse, Keyborad, etc." class="form-control input-md" type="text">

                    </div>
                </div>


                <!-- Text input-->
                <div class="form-group">
                    <label class="col-md-4 control-label" for="textinput">Price</label>
                    <div class="col-md-4">
                        <input v-model="Item.price" placeholder="56.22" class="form-control input-md" type="text">

                    </div>
                </div>
                <!-- Button -->
                <div class="form-group">
                    <label class="col-md-4 control-label" for=""></label>
                    <div class="col-md-4">
                        <button @click="UpdateData()" class="btn btn-primary">Update</button>
                    </div>
                </div>


            </fieldset>
        </div>


    </div>
</template>

<script>
    export default {
        data() {
            return {
                msg: 'Store Home - Update item',
                Item: {},
                Id: null
            }
        },
        methods: {
            UpdateData: function () {
                try {
                    this.$http.put('/api/Items', { Id:this.Id, Name: this.Item.name, Price: this.Item.price }).then(result => {
                        console.log(result);
                        alert(`Item ${result.data.name} has been updated successfully`);
                        this.Item = {};
                    });

                } catch (error) {
                    console.log(error)
                }
            },
            GetItem: function () {
                try {
                    this.$http.get('/api/Items/' + this.Id).then(result => {
                        console.log(result);
                        this.Item = {};
                        this.Item = result.data;
                    });

                } catch (error) {
                    alert("Item not found");
                    console.log(error)
                }
            }
        }
    }
</script>

<style>
</style>
