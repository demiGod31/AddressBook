<template>
  <div>
    <b-form @submit="onSubmit" @reset="onReset" v-if="show">

        <b-form-group id="input-group-1" label="ID" label-for="input-1">
        <b-form-input
          id="input-1"
          v-model="form.eId"
          required
        >{{this.eId}}</b-form-input>
      </b-form-group>
     
        <b-form-group id="input-group-2" label="Updated Name:" label-for="input-2">
        <b-form-input
          id="input-2"
          v-model="form.eName"
          required
          
        ></b-form-input>
      </b-form-group>

      <b-form-group id="input-group-3" label="Updated Number:" label-for="input-3">
        <b-form-input
          id="input-3"
          v-model="form.eNumber"
          required
        
        >{{this.eNumber}}</b-form-input>
      </b-form-group>
      <b-button type="submit" variant="primary">Update</b-button>
      <b-button type="reset" variant="danger">Reset</b-button>
    </b-form>
    </div>
</template>

<script>
import axios from 'axios';
  export default {
    data() {
      return {
        form: {
          eId:"",
          eName:"",
          eNumber:""
        },
        
        show: true
      }
    },
    mounted() {
      debugger;
            this.form.eId = this.$route.params.eID;
            this.form.eName = this.$route.params.eNAME;
            this.form.eNumber = this.$route.params.eNUMBER;
        },
    
    methods: {
      onSubmit(evt) {
        evt.preventDefault()
        alert("Data Successfully Updated!");
                axios.post('http://localhost:50069/api/AddressBook/Update',
                    this.form
                )
               
                .then((response) => {})
                .catch((evt) => {
                console.error(evt)
  })
      },
      onReset(evt) {
        evt.preventDefault()
        // Reset our form values
        this.form.eId=''
        this.form.eNumber = ''
        this.form.eName = ''
        // Trick to reset/clear native browser form validation state
        this.show = false
        this.$nextTick(() => {
          this.show = true
        })
      }
    }
  }
</script>